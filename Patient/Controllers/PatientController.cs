using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using Patient.Data;
using Patient.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Patient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService ?? throw new ArgumentNullException(nameof(patientService));

        }
        /// <summary>
        /// Get all Patients
        /// </summary>
        /// <returns>retunr the list of patients</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_patientService.GetPatients());
        }

        /// <summary>
        /// Get patient by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the patient with the passed</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _patientService.GetPatient(id) != null ? Ok(_patientService.GetPatient(id)) : NoContent();
        }



        /// <summary>
        /// Add patient
        /// </summary>
        /// <param name="patient"></param>
        /// <retuns>Return the added patient</retuns>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Patient patient)
        {
            return Ok(_patientService.AddPatient(patient));
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="patient"></param>
        [HttpPut]
        public IActionResult Put([FromBody] Models.Patient patient)
        {
            return Ok(_patientService.UpdatePatient(patient));
        }


        /// <summary>
        /// Delete the patient with the passed ID
        /// </summary>
        /// <param name="id"></param>
        ///  <returns></returns>
        // DELETE api/<PatientController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _patientService.DeletePatient(id);
            return result.HasValue & result == true ? Ok($"patient with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the patient with ID:{id}.");
        }
    }
}
