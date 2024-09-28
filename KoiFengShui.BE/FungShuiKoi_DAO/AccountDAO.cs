using FengShuiKoi_BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FengShuiKoi_DAO
{
	public class AccountDAO
	{
		private SWP391_FengShuiKoiConsulting_DBContext dbContext;
		private static AccountDAO instance = null;
		public static AccountDAO Instance
		{
			get
			{
				//singleton design pattern
				if (instance == null)
				{
					instance = new AccountDAO();
				}
				return instance;
			}
		}
		public AccountDAO()
		{
			dbContext = new SWP391_FengShuiKoiConsulting_DBContext();
		}
		public Account GetAccountByEmail(string email)
		{
			return dbContext.Accounts.SingleOrDefault(m => m.Email.Equals(email));
		}
		public Account GetAccountByUserID(string userid)
		{
			return dbContext.Accounts.SingleOrDefault(m => m.Email.Equals(userid));
		}

		public List<Account> GetHraccounts()
		{
			return dbContext.Accounts.ToList();
		}
	}
}
