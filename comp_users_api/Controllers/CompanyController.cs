using comp_users_api.Data;
using comp_users_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comp_users_api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CompanyController : Controller
    {

        private readonly CompanyDbContext _companyDbContext;
        private readonly SubscriptionDbContext _subscriptionDbContext;
        private readonly PlanDbContext _planDbContext;
        private readonly BillingDbContext _billingDbContext;
        private readonly CycleDbContext _cycleDbContext;

        public CompanyController(
            CompanyDbContext companyDbContext,
            SubscriptionDbContext subscriptionDbContext,
            PlanDbContext planDbContext,
            BillingDbContext billingDbContext,
            CycleDbContext cycleDbContext
            )
        {
            _companyDbContext = companyDbContext;
            _subscriptionDbContext = subscriptionDbContext;
            _planDbContext = planDbContext;
            _billingDbContext = billingDbContext;
            _cycleDbContext = cycleDbContext;
        }


        [HttpGet("{Id}")]
        public async Task<IActionResult> GetCompanyDetails(int Id)
        {

            var companyDetails = await _companyDbContext.Company.FindAsync(Id);
            var subscriptionDetails = await _subscriptionDbContext.Subscription.Where(cu => cu.Company == Id).ToListAsync();
            //var plan = await _planDbContext.Plan.Where(cu => cu.Id == subscriptionDetails.First().Plan).ToListAsync();
            var billing = await _billingDbContext.Billing.Where(cu => cu.Company == Id).ToListAsync();
            var cycle = await _cycleDbContext.BillingCycle.Where(cu => cu.Company == Id).ToListAsync();

            var subscription = subscriptionDetails.FirstOrDefault();

            if (companyDetails == null)
            {
                return NotFound();
            }

            if (subscription != null && billing != null)
            {
                var plan = await _planDbContext.Plan.Where(cu => cu.Id == subscriptionDetails.First().Plan).ToListAsync();

                var companyInfo = new
                {
                    name = companyDetails.Name,
                    tin = companyDetails.Tin,
                    email = companyDetails.Email,
                    planName = plan.Any() ? plan.First().Name : string.Empty,
                    dateExpired = subscription != null ? subscription.DateExpired : DateTime.MinValue,
                    dateCreated = billing.First().DateCreated,
                    card = billing.First().Card,
                    cycleType = cycle.First().CycleType,
                    status = cycle.First().Status,
                    cycleDateCreated = cycle.First().DateCreated,
                    paymentId = cycle.First().Payment,
                };

                return Ok(companyInfo); 
            }
            else
            {

                var companyInfo = new
                {
                    name = companyDetails.Name,
                    tin = companyDetails.Tin,
                    email = companyDetails.Email,
                    planName = "",
                    dateExpired = DateTime.MinValue,
                    dateCreated = DateTime.MinValue,
                    card = 0,
                    cycleType = "",
                    status = 0,
                    cycleDateCreated = DateTime.MinValue,
                    paymentId = 0,
                };

                return Ok(companyInfo);
            }

        }
    }
}
