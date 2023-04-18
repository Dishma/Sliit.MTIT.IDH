namespace Patient.Services
{
    public interface IPatientService
    {
        List<Models.Patient> GetPatients();
        Models.Patient? GetPatient(int id);
        Models.Patient? AddPatient(Models.Patient patient);
        Models.Patient? UpdatePatient(Models.Patient patient);
        bool? DeletePatient(int id);
    }
}

