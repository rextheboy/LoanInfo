using System.Collections.Generic;
using IBatisNet.DataMapper;
using LI.PlainObject;
using System;

namespace LI.DataAccess
{
    public class LoanDao
    {
        #region C,U,D methods

        public void InsertItem(Loan item)
        {
            Mapper.Instance().Insert("Loans-Insert", item);
        }

        public void UpdateItem(Loan item)
        {
            Mapper.Instance().Update("Loans-Update", item);
            //Console.WriteLine(Mapper.Instance().GetMappedStatement("Loans-Update").ToString());
        }

        public void DeleteItem(int id)
        {
            Mapper.Instance().Delete("Loans-Delete-Id", id);
        }

        #endregion

        #region get methods

        public Loan GetItem(int id)
        {
            return Mapper.Instance().QueryForObject<Loan>("Loans-Select-Id", id);
        }

        public IList<Loan> GetItems()
        {
            return Mapper.Instance().QueryForList<Loan>("Loans-Select-All", null);
        }

        #endregion

        #region get count methods

        /// <summary>
        /// 从数据库获得"贷款"笔数
        /// </summary>
        /// <returns>"贷款"笔数</returns>
        public int GetCount()
        {
            return Mapper.Instance().QueryForObject<int>("Loan-Count-All", null);
        }

        #endregion
    }
}
