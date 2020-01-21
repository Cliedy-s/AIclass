using DTO;
using FORTEST_01_WEBAPI.DAC;
using FORTEST_02_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FORTEST_01_WEBAPI.Controllers
{
    [RoutePrefix("api/Production")]
    public class ProductionController : ApiController
    {
        ProductionDAC dac = new ProductionDAC();

        // GET
        /// <summary>
        /// 전체 내역 출력
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetProductionRecord")]
        public List<ProductNProductionVO> GetProductionRecord()
        {
            return dac.GetProductionRecord();
        }
        /// <summary>
        /// 제품 번호로 내역 검색
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetProductionRecordByProductID/{id}")]
        public List<ProductNProductionVO> GetProductionRecordByProductID(int id)
        {
            return dac.GetProductionRecordByProductID(id);
        }
        /// <summary>
        /// 내역 날짜로 내역 검색
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetProductionRecordByDate/{fromDate}/{toDate}")]
        public List<ProductNProductionVO> GetProductionRecordByDate(DateTime fromDate, DateTime toDate)
        {
            return dac.GetProductionRecordByDate(fromDate, toDate);
        }
        /// <summary>
        /// 내역 번호로 내역 검색
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetProductionRecordBySeq/{id}")]
        public IHttpActionResult GetProductionRecordBySeq(int id)
        {
            Message<ProductNProductionVO> msg = new Message<ProductNProductionVO>();
            msg.Data =  dac.GetProductionRecordBySeq(id);
            if (msg.Data == null)
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
        /// 내역 삭제
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("DeleteProductionRecord/{id}")]
        public IHttpActionResult DeleteProductionRecord(int id)
        {
            Message msg = new Message();
            string result = dac.DeleteProductionRecord(id);
            switch (result)
            {
                case "C301":
                    msg.IsSuccess = false;
                    msg.ResultMessage = "삭제에 실패하였습니다.";
                    break;
                case "C302":
                    msg.IsSuccess = false;
                    msg.ResultMessage = "존재하지 않는 seq번호입니다.";
                    break;
                case "C202":
                    msg.IsSuccess = true;
                    msg.ResultMessage = "삭제에 성공하였습니다.";
                    break;
            }
            return Ok(msg);
        }

        /// <summary>
        /// 등록하거나 수정
        /// </summary>
        /// <param name="production"></param>
        /// <returns></returns>
        // POST
        [HttpPost]
        [Route("InorUpProductionRecord")]
        public IHttpActionResult InorUpProductionRecord([FromBody]ProductionVO production)
        {
            Message<ProductionVO> msg = new Message<ProductionVO>();
            string result = dac.InorUpProductionRecord(production);
            switch (result)
            {
                case "C200":
                    msg.IsSuccess = true;
                    msg.ResultMessage = "수정에 성공하였습니다.";
                    break;
                case "C201":
                    msg.IsSuccess = true;
                    msg.ResultMessage = "등록에 성공하였습니다.";
                    break;
                case "C202":
                    msg.IsSuccess = false;
                    msg.ResultMessage = "수정 및 등록에 실패하였습니다.";
                    break;
            }
            return Ok(msg);
        }

    }
}
