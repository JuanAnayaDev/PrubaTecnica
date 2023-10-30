using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PruebaTecnicaV2.Models.DB;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace PruebaTecnicaV2.Controllers
{
    public class CandidatesController : Controller
    {
        public IActionResult Index()
        {
                return View();
        }

        [HttpGet]
        public async Task<JsonResult> GetCandidates()
        {
            string jsonString = string.Empty;
            try
            {
                List<Candidates> lst = new List<Candidates>();
                using (var db = new Models.DB.PruebaTecnicaDBContext())
                {
                    lst = await db.candidates.ToListAsync();
                }
                jsonString = JsonSerializer.Serialize(lst);
                return Json(jsonString);
            }catch(Exception ex)
            {
                jsonString = JsonSerializer.Serialize(ex.Message);
                return Json(jsonString);
            }
        }

        [HttpPost]
        public async Task<JsonResult> SaveCandidates(Candidates candidates)
        {
            string jsonString = string.Empty;
            try
            {

                var candidate = new Candidates
                {
                    Name = candidates.Name,
                    Surname = candidates.Surname,
                    Birthdate = candidates.Birthdate,
                    Email = candidates.Email,
                    InsertDate = DateTime.Now
                };

                using (var db = new PruebaTecnicaDBContext())
                {
                    db.candidates.Add(candidate);
                    await db.SaveChangesAsync();

                    var experiences = new List<Candidateexperiences>(candidates.Candidateexperiences);

                    foreach (var experince in experiences)
                    {
                        experince.IdCandidateNavigation = candidate;
                        experince.InsertDate = DateTime.Now;
                    }

                    db.candidateexperiences.AddRange(experiences);
                    await db.SaveChangesAsync();
                }

                return Json(true);
            }catch (Exception ex)
            {
                jsonString = JsonSerializer.Serialize(ex.Message);
                return Json(jsonString);
            }
        }

        [HttpGet]
        public async Task<JsonResult> GetCandidatesDetail(int IdCandidate)
        {
            string jsonString = string.Empty;

            try
            {
                List<Candidateexperiences> candidateexperiences = new List<Candidateexperiences>();
                using (var db = new Models.DB.PruebaTecnicaDBContext())
                {
                    candidateexperiences = await db.candidateexperiences.Where(x => x.IdCandidate == IdCandidate).ToListAsync();
                }
                jsonString = JsonSerializer.Serialize(candidateexperiences);
                return Json(jsonString);
            }
            catch(Exception ex)
            {
                jsonString = JsonSerializer.Serialize(ex.Message);
                return Json(jsonString);
            }
        }

        [HttpPut]
        public async Task<JsonResult> EditCandidates(Candidates candidates,int IdCandidate)
        {
            string jsonString = string.Empty;
            try
            {
                using (var db = new PruebaTecnicaDBContext())
                {
                    var existingCandidate = await db.candidates.Include(c => c.Candidateexperiences)
                        .FirstOrDefaultAsync(c => c.IdCandidate == IdCandidate);

                    if (existingCandidate != null)
                    {
                        existingCandidate.Name = candidates.Name;
                        existingCandidate.Surname = candidates.Surname;
                        existingCandidate.Birthdate = candidates.Birthdate;
                        existingCandidate.Email = candidates.Email;
                        existingCandidate.ModifyDate = DateTime.Now;

                        foreach (var experience in existingCandidate.Candidateexperiences)
                        {
                            var updatedExperience = candidates.Candidateexperiences.FirstOrDefault(e => e.IdCandidateExperience == experience.IdCandidateExperience);

                            if (updatedExperience != null)
                            {
                                experience.Company = updatedExperience.Company;
                                experience.Job = updatedExperience.Job;
                                experience.Description = updatedExperience.Description;
                                experience.Salary = updatedExperience.Salary;
                                experience.BeginDate = updatedExperience.BeginDate;
                                experience.EndDate = updatedExperience.EndDate;
                                experience.ModifyDate = DateTime.Now;
                            }
                        }

                        await db.SaveChangesAsync();
                    }
                }

                return Json(true);
            }
            catch (Exception ex)
            {
                jsonString = JsonSerializer.Serialize(ex.Message);
                return Json(jsonString);
            }
        }

        [HttpDelete]
        public async Task<JsonResult> DeleteCandidate(int IdCandidate)
        {
            string jsonString = string.Empty;
            try
            {
                using (var db = new PruebaTecnicaDBContext())
                { 
                    var experienceToDelete = await db.candidateexperiences.FirstOrDefaultAsync(c => c.IdCandidate == IdCandidate);
                    if (experienceToDelete != null)
                    {
                        db.candidateexperiences.Remove(experienceToDelete);
                        await db.SaveChangesAsync();
                    }
                    var candidates = db.candidates.FirstOrDefault(c => c.IdCandidate == IdCandidate);
                    if (candidates != null)
                    {
                        db.candidates.Remove(candidates);
                        await db.SaveChangesAsync();
                    }
                }
                return Json(true);
                }catch(Exception ex)
            {
                jsonString = JsonSerializer.Serialize(ex.Message);
                return Json(jsonString);
            }
        }
    }
}
