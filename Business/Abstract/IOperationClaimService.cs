﻿using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOperationClaimService
    {
        IDataResult<OperationClaim> GetById(int id);

        IDataResult<OperationClaim> GetByName(string name);

        IDataResult<List<OperationClaim>> GetAll();

        IResult Add(OperationClaim operationClaim);

        IResult Update(OperationClaim operationClaim);

        IResult Delete(OperationClaim operationClaim);
    }
}
