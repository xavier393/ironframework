﻿using DataServiceClient;
using DataTransferObject;
using DataTransferObject.Model;
using IronFramework.Utility;
using MVC5Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;

namespace MvcApp.Tests.Controllers
{
    /// <summary>
    /// NewEmployeeControllerTests
    /// </summary>
    public class NewEmployeeControllerTests
    {
        /// <summary>
        /// Tests the update entity.
        /// </summary>
        /// <returns></returns>
        [Fact]
        //[AutoRollback]
        public async Task GetEntityTest()
        {
            var controller = new EmployeeController();
            controller.rESTAPIWrapperClinet = new RESTAPIWrapperClinet(ServiceConfig.URI);
            var results=await controller.Get(1);

            var dto=results.Data as EmployeeDto;
            Assert.NotNull(dto);
            //dto.Title = dto.Title + "1";
        }

        [Fact]
        public async Task UpdateEntityTests()
        {
            var controller2 = new EmployeeController();
            controller2.rESTAPIWrapperClinet = new RESTAPIWrapperClinet(ServiceConfig.URI);
            var dto = CreateDTO();
            bool flag = await controller2.Post(dto);
            Assert.True(flag);

            var getDto=await controller2.Find(dto, 1, 1);
            Assert.NotNull(getDto.Data);
            var dbEntity=getDto.Data as EasyuiDatagridData<EmployeeDto>;

            await controller2.Delete(dbEntity.Rows.FirstOrDefault().EmployeeID);
        }

        private EmployeeDto CreateDTO()
        {
            var employee = new EmployeeDto
            {
                ManagerID = 2,
                ContactID = 3,
                Title = "Developer",
                BirthDate = new DateTime(1965, 1, 1, 0, 0, 0),
                HireDate = DateTime.Now,
                Gender = "M",
                MaritalStatus = "M",
                ModifiedDate = DateTime.Now,
                NationalIDNumber = DateTime.Now.ToString("hhmmddss"),
                rowguid = new Guid(),
                CurrentFlag = true,
                VacationHours = 2,
                SickLeaveHours = 3,
                SalariedFlag = false,
                LoginID = "peter"+DateTime.Now.Ticks.ToString()
            };
            return employee;
        }

    }
}
