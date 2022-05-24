﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RDKSDatabase.Data;
using RDKSDatabase.Models;
using RDKSDatabase.Models.ViewModels;

namespace RDKSDatabase.Controllers
{
    public class ValidationsController : Controller
    {
        private readonly RDKSDatabaseContext _context;

        public ValidationsController(RDKSDatabaseContext context)
        {
            _context = context;
        }

        // GET: Validations
        public async Task<IActionResult> Index(int? materialCode, string? facility)
        /*        {
                    var viewModel = new ImportCode();
                    viewModel.Validations = await _context.Validation
                          .Include(i => i.Transactions)
                          .AsNoTracking()
                          .OrderBy(i => i.VALID_IMPORT_CODE)
                          .ToListAsync();

                    if (materialCode != null)
                    {
                        ViewData["VALID_IMPORT_CODE"] = materialCode.Value;
                        Validation validation = viewModel.Validations.Where(
                            i => i.ID == id.Value).Single();
                        viewModel.Courses = instructor.CourseAssignments.Select(s => s.Course);
                    }

                    if (facility != null)
                    {
                        ViewData["CourseID"] = courseID.Value;
                        viewModel.Enrollments = viewModel.Courses.Where(
                            x => x.CourseID == courseID).Single().Enrollments;
                    }

                    return View(viewModel);
                }*/
        {
            return _context.Validation != null ?
                        View(await _context.Validation.ToListAsync()) :
                        Problem("Entity set 'RDKSDatabaseContext.Validation'  is null.");
        }

        // GET: Validations/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Validation == null)
            {
                return NotFound();
            }

            var validation = await _context.Validation
                .FirstOrDefaultAsync(m => m.VALID_IMPORT_CODE == id);
            if (validation == null)
            {
                return NotFound();
            }

            return View(validation);
        }

        // GET: Validations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Validations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VALID_IMPORT_CODE,VALID_CODE,VALID_MATERIAL_NAME,VALID_IN_AND_OUT,VALID_AIRSPACE_OR_NONAIRSPACE,VALID_FUNCTION,VALID_FACILITY,VALID_MATERIAL_GROUP,VALID_CURBSIED_AREA,VALID_CURBSIDE_STREAM,VALID_FR_ANNUAL_REPORTING_GROUP,VALID_FR_ANNUAL_REPORT_WASTE_TYPE,VALID_TIPPING_RATE,VALID_SERVICE_AREA")] Validation validation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(validation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(validation);
        }

        // GET: Validations/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Validation == null)
            {
                return NotFound();
            }

            var validation = await _context.Validation.FindAsync(id);
            if (validation == null)
            {
                return NotFound();
            }
            return View(validation);
        }

        // POST: Validations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("VALID_IMPORT_CODE,VALID_CODE,VALID_MATERIAL_NAME,VALID_IN_AND_OUT,VALID_AIRSPACE_OR_NONAIRSPACE,VALID_FUNCTION,VALID_FACILITY,VALID_MATERIAL_GROUP,VALID_CURBSIED_AREA,VALID_CURBSIDE_STREAM,VALID_FR_ANNUAL_REPORTING_GROUP,VALID_FR_ANNUAL_REPORT_WASTE_TYPE,VALID_TIPPING_RATE,VALID_SERVICE_AREA")] Validation validation)
        {
            if (id != validation.VALID_IMPORT_CODE)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(validation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ValidationExists(validation.VALID_IMPORT_CODE))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(validation);
        }

        // GET: Validations/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Validation == null)
            {
                return NotFound();
            }

            var validation = await _context.Validation
                .FirstOrDefaultAsync(m => m.VALID_IMPORT_CODE == id);
            if (validation == null)
            {
                return NotFound();
            }

            return View(validation);
        }

        // POST: Validations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Validation == null)
            {
                return Problem("Entity set 'RDKSDatabaseContext.Validation'  is null.");
            }
            var validation = await _context.Validation.FindAsync(id);
            if (validation != null)
            {
                _context.Validation.Remove(validation);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ValidationExists(string id)
        {
          return (_context.Validation?.Any(e => e.VALID_IMPORT_CODE == id)).GetValueOrDefault();
        }
    }
}
