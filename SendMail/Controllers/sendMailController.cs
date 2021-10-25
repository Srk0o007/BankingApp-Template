using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using SOSUDAPAYAPI.EmailServices;
using SOSUDAPAYAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SendMail.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllHeaders")]
    public class sendMailController : ControllerBase
    {
        /// <summary>
        /// The email service
        /// </summary>
        private IEmailService _emailService;


        /// <summary>
        /// Initializes a new instance of the <see cref="sendMailController"/> class.
        /// </summary>
        /// <param name="emailService">The email service.</param>
        public sendMailController(IEmailService emailService)
        {
            _emailService = emailService;           
        }

        // POST api/<sendMailController>
        [Route("[action]")]
        [HttpPost("sendMail")]
        public IActionResult sendMail([FromBody] SOSUDAPAYAPI.Models.Email model)
        {
            try
            {
                _emailService.SendEmail(model.To, model.Subject, model.Body);
                return Ok("success");
            }
            catch (Exception)
            {

                return Ok("failure"); ;
            }
        }


        // POST api/<SendNotification>
        [Route("[action]")]
        [HttpPost("notification")]
        public IActionResult notification([FromBody] SOSUDAPAYAPI.Models.Email model)
        {
            try
            {
                _emailService.SendEmail(model.To, model.Subject, model.Body);
                return Ok("success");
            }
            catch (Exception)
            {

                return Ok("failure"); ;
            }
           
        }


        // POST api/<contactUs>
        [Route("[action]")]
        [HttpPost("contactUs")]
        public IActionResult contactUs([FromBody] SOSUDAPAYAPI.Models.Email model)
        {
            try
            {
                _emailService.SendEmail(model.To, model.Subject, model.Body);
                return Ok("success");
            }
            catch (Exception)
            {

                return Ok("failure"); ;
            }
        }



    }
}
