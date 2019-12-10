using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace IceCreamManager.DAC
{
    public class SampleDAC : DACParent
    {
        //public override List<BOMVO> SelectAll<BOMVO>()
        //{
        //    using (SqlCommand comm = new SqlCommand())
        //    {
        //        comm.Connection = new SqlConnection(Connstr);
        //        comm.CommandText = "<프로시저 이름>";
        //        comm.CommandType = CommandType.StoredProcedure;

        //        comm.Connection.Open();
        //        SqlDataReader reader = comm.ExecuteReader();
        //        List<BOMVO> bomlist = Helper.DataReaderMapToList<BOMVO>(reader);
        //        comm.Connection.Close();

        //        //TODO - 수정 : 프로시저 이름 입력 후 return bomlist
        //        throw new NotImplementedException();
        //        // return bomlist;
        //    }
        //}
        ///// <summary>
        ///// 존재하는 넘버인지 확인
        ///// </summary>
        //public override bool IsIDValid(int no)
        //{
        //    using (SqlCommand comm = new SqlCommand())
        //    {
        //        comm.Connection = new SqlConnection(Connstr);
        //        comm.CommandText = "SELECT count(*) FROM Materials WHERE mat_No = @mat_No";
        //        comm.CommandType = CommandType.Text;

        //        comm.Parameters.AddWithValue("@mat_No", no);

        //        comm.Connection.Open();
        //        int result = Convert.ToInt32(comm.ExecuteScalar());
        //        comm.Connection.Close();

        //        if (result > 0)
        //            return true;
        //        return false;
        //    }
        //}

        //public override int Delete(int id)
        //{
        //    return base.Delete(id);
        //}

        //public override int Insert<T>(T item)
        //{
        //    return base.Insert(item);
        //}

        //public override int Update<T>(T item)
        //{
        //    return base.Update(item);
        //}
    }
}
