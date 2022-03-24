﻿using JWTTokenAuthentication_DAL.Contracts;
using JWTTokenAuthentication_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWTTokenAuthentication_BAL.Services
{
    public class ServiceAppUser
    {
        public readonly IRepository<AppUser> _repository;
        public ServiceAppUser(IRepository<AppUser> repository)
        {
            _repository = repository;
        }
        //Create Method
        public async Task<AppUser> AddUser(AppUser appUser)
        {
            try
            {
                if (appUser == null)
                {
                    throw new ArgumentNullException(nameof(appUser));
                }
                else
                {
                    return await _repository.Create(appUser);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void DeleteUser(int Id)
        {
            try
            {
                if (Id != 0)
                {
                    var obj = _repository.GetAll().Where(x => x.Id == Id).FirstOrDefault();
                    _repository.Delete(obj);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void UpdateUser(int Id)
        {
            try
            {
                if (Id != 0)
                {
                    var obj = _repository.GetAll().Where(x => x.Id == Id).FirstOrDefault();
                    if (obj != null) _repository.Update(obj);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IEnumerable<AppUser> GetAllUser()
        {
            try
            {
                return _repository.GetAll().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
