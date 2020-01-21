using _0115_01_WebAPI_Users.DAC;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _0115_01_WebAPI_Users.Controllers
{
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
        UserDAC dac = new UserDAC();

        /// <summary>
        /// 전체 사용자 목록 조회
        /// </summary>
        /// <returns><![CDATA[List<UserVO>]]></returns>
        [Route("GetAllUsers")]
        public List<UserVO> GetAllUsers()
        {
            return dac.GetAllUsers();
        }

        /// <summary>
        /// 특정 사용자 정보 조회
        /// </summary>
        /// <param name="id">seq</param>
        /// <returns><![CDATA[Message<UserVO>]]></returns>
        [Route("GetUserInfo/{id}")]
        public IHttpActionResult GetUserInfo(int id)
        {
            Message<UserVO> msg = new Message<UserVO>();
            msg.Data = dac.GetUserInfo(id);
            if(msg.Data == null)
            {
                msg.IsSuccess = false;
                msg.ResultMessage = "해당하는 정보가 없습니다.";
            }
            else
            {
                msg.IsSuccess = true;
                msg.ResultMessage = "정보를 성공적으로 불러왔습니다.";
            }
            return Ok(msg);
        }

        /// <summary>
        /// 사용자 신규 등록(id:0) / 수정(id:n)
        /// </summary>
        /// <param name="user">UserVO</param>
        /// <returns><![CDATA[Message<UserVO>]]></returns>
        [HttpPost]
        [Route("SaveUser")] //Post : api/User/SaveUser
        public IHttpActionResult SaveUser([FromBody]UserVO user)
        {
            Message<UserVO> msg = new Message<UserVO>();
            string result = dac.SaveUser(user);
            switch (result)
            {
                case "C200":
                    msg.IsSuccess = true;
                    if (user.id == 0)
                        msg.ResultMessage = "성공적으로 등록되었습니다.";
                    else
                        msg.ResultMessage = "성공적으로 수정되었습니다.";
                    break;
                case "C201":
                    msg.IsSuccess = false;
                    msg.ResultMessage = "이미 등록된 이메일입니다.";
                    break;
                case "C202":
                    msg.IsSuccess = false;
                    msg.ResultMessage = "이미 등록된 휴대폰 번호입니다.";
                    break;
            }
            return Ok(msg);
        }

        /// <summary>
        /// 특정 id의 사용자 삭제
        /// </summary>
        /// <param name="id">id</param>
        /// <returns><![CDATA[Message<UserVO>]]></returns>
        [HttpGet]
        [Route("DelUser/{id}")]
        public IHttpActionResult DelUser(int id)
        {
            Message msg = new Message();
            string result = dac.DeleteUser(id);
            switch (result)
            {
                case "C200":
                    msg.IsSuccess = true;
                    msg.ResultMessage = "성공적으로 삭제되었습니다.";
                    break;
                case "C203":
                    msg.IsSuccess = false;
                    msg.ResultMessage = "존재하지 않는 사용자입니다.";
                    break;
            }
            return Ok(msg);
        }
    }
}
