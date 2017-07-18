using Homework1.Models;
using Homework1.Models.ViewModels;
using Homework1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework1.Service
{
    public class AccountService
    {
        private readonly IRepository<AccountBook> _logRep;
        private readonly IUnitOfWork _unitOfWork;

        public AccountService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _logRep = new Repository<AccountBook>(unitOfWork);
        }
        public IList<MoneyViewModel> Get()
        {
            var source = _logRep.LookupAll();
            var result = source.Select(account => new MoneyViewModel()
            {
                Type = account.Categoryyy==1?"支出":"收入",
                Cost= account.Amounttt,
                CostDate=account.Dateee
            }).OrderByDescending(a=>a.CostDate).ToList();
            return result;
        }
        public void AddAccount(CreateMoneyViewModel CMVM)
        {
            AccountBook ab = new AccountBook() {
                Remarkkk=CMVM.Memo,
                Amounttt=CMVM.Cost,
                Categoryyy=CMVM.Type,
                Dateee=CMVM.CostDate,
                Id=Guid.NewGuid()
            };
            _logRep.Create(ab);
        }
        public void Save()
        {
            _unitOfWork.Save();
        }
        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}