using System;

namespace LI.PlainObject
{
    #region Loan
    /// <summary>
    /// 贷款信息实体类
    /// </summary>
    public class Loan
    {
        #region Public Properties

        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// 贷款方
        /// </summary>
        public string Lender
        { get; set; }

        /// <summary>
        /// 贷款金额
        /// </summary>
        public decimal Money
        {
            get;
            set;
        }

        /// <summary>
        /// 已还本金
        /// </summary>
        public decimal RepaymentAmount
        {
            get;
            set;
        }

        /// <summary>
        /// 贷款余额
        /// </summary>
        public decimal Balance
        {
            get;
            set;
        }

        /// <summary>
        /// 贷款状态
        /// </summary>
        public LoanConditions Condition
        {
            get;
            set;
        }

        /// <summary>
        /// 所属银行
        /// </summary>
        public string Bank
        {
            get;
            set;
        }

        /// <summary>
        /// 银行的客户经理
        /// </summary>
        public string BankManager
        {
            get;
            set;
        }

        /// <summary>
        /// 年利率
        /// </summary>
        public double AnnualInterestRate
        {
            get;
            set;
        }

        /// <summary>
        /// 合同签订日期
        /// </summary>
        public DateTime ContractSigningDate
        {
            get;
            set;
        }

        /// <summary>
        /// 发放贷款日期
        /// </summary>
        public DateTime LoanDate
        {
            get;
            set;
        }

        /// <summary>
        /// 贷款到期日期
        /// </summary>
        public DateTime LoanMaturity
        {
            get;
            set;
        }

        /// <summary>
        /// 贷款结清日期
        /// </summary>
        public DateTime SettlementDate
        {
            get;
            set;
        }

        /// <summary>
        /// 抵押物信息
        /// </summary>
        public string PawnInfo
        {
            get;
            set;
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark
        {
            get;
            set;
        }

        public bool IfDelete
        {
            get;
            set;
        }

        public int RegUserId
        {
            get;
            set;
        }

        public DateTime RegDate
        {
            get;
            set;
        }

        public int UpdateUserId
        {
            get;
            set;
        }

        public DateTime UpdateDate
        {
            get;
            set;
        }

        #endregion

        /// <summary>
        /// 贷款状态
        /// </summary>
        public enum LoanConditions
        {
            /// <summary>
            /// 全部
            /// </summary>
            All = -1,
            /// <summary>
            /// 正常
            /// </summary>
            Normal = 0,
            /// <summary>
            /// 已还
            /// </summary>
            Paid = 1,
            /// <summary>
            /// 已逾期
            /// </summary>
            Overdue = 2
        }

        //public static Loan GetLoan(int id)
        //{
        //    return new Loan(id);
        //}

        //public Loan(int id)
        //{
        //    SqlService sql = new SqlService();
        //    sql.AddParameter("@Id", SqlDbType.Int, id);
        //    SqlDataReader reader = sql.ExecuteSqlReader("SELECT * FROM Loans WHERE Id = '" + id.ToString() + "'");

        //    if (reader.Read())
        //    {
        //        this.LoadFromReader(reader);
        //        reader.Close();
        //    }
        //    else
        //    {
        //        if (!reader.IsClosed) reader.Close();
        //        throw new ApplicationException("Loan does not exist.");
        //    }
        //}

        //public Loan(SqlDataReader reader)
        //{
        //    this.LoadFromReader(reader);
        //}

        //protected void LoadFromReader(SqlDataReader reader)
        //{
        //    if (reader != null && !reader.IsClosed)
        //    {
        //        _id = reader.GetInt32(0);
        //        if (!reader.IsDBNull(1)) _money = reader.GetDecimal(1);
        //        if (!reader.IsDBNull(2)) _repaymentAmount = reader.GetDecimal(2);
        //        if (!reader.IsDBNull(3)) _balance = reader.GetDecimal(3);
        //        if (!reader.IsDBNull(4)) _condition = reader.GetByte(4);
        //        if (!reader.IsDBNull(5)) _bank = reader.GetString(5);
        //        if (!reader.IsDBNull(6)) _bankManager = reader.GetString(6);
        //        if (!reader.IsDBNull(7)) _annualInterestRate = reader.__SQL__Double(7);
        //        if (!reader.IsDBNull(8)) _contractSigningDate = reader.GetDateTime(8);
        //        if (!reader.IsDBNull(9)) _loanDate = reader.GetDateTime(9);
        //        if (!reader.IsDBNull(10)) _loanMaturity = reader.GetDateTime(10);
        //        if (!reader.IsDBNull(11)) _settlementDate = reader.GetDateTime(11);
        //        if (!reader.IsDBNull(12)) _pawnInfo = reader.GetString(12);
        //        if (!reader.IsDBNull(13)) _remark = reader.GetString(13);
        //        if (!reader.IsDBNull(14)) _ifDelete = reader.GetBoolean(14);
        //        if (!reader.IsDBNull(15)) _regUserId = reader.GetInt32(15);
        //        if (!reader.IsDBNull(16)) _regDate = reader.GetDateTime(16);
        //        if (!reader.IsDBNull(17)) _updateUserId = reader.GetInt32(17);
        //        if (!reader.IsDBNull(18)) _updateDate = reader.GetDateTime(18);
        //    }
        //}
    }
    #endregion
}
