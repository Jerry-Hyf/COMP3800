﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RDKSDatabase.Data;
using RDKSDatabase.Models;

namespace RDKSDatabase.Controllers
{
    public class TransactionsController : Controller
    {
        private readonly RDKSDatabaseContext _context;

        public TransactionsController(RDKSDatabaseContext context)
        {
            _context = context;
        }

        // GET: Transactions
        public async Task<IActionResult> Index()
        {
              return _context.Transaction != null ? 
                          View(await _context.Transaction.ToListAsync()) :
                          Problem("Entity set 'RDKSDatabaseContext.Transaction'  is null.");
        }

        // GET: Transactions/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Transaction == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transaction
                .FirstOrDefaultAsync(m => m.TRANS_NUM == id);
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        // GET: Transactions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Transactions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TRANS_NUM,CUS_ID,LICENSE_PLATE,TRANS_COMPLETION_DATE,TRANS_COMPLETION_TIME,TRANS_LOAD_NUM,TRANS_NETWEIGHT,TRANS_TOTALPRICE,TRANS_HAULER,TRANS_DRIVER_EXEMPT_STATUS,VALID_IMPORT_CODE,TRANS_CONTRACT,TRANS_OPERATION,TRANS_STATUS,TRANS_ISMANUAL,TRANS_HASEXCEPTION,TRANS_SOURCE_TYPE,TRANS_ADJUSTED_PRICE,TRANS_FACILITY_CODE,TRANS_TONNES,TRANS_CUBIC_METERS,TRANS_IN_SERVICE_AREA,TRANS_ASC_NON_ASC,TRANS_FUNCTION,TRANS_CURBSIDE_AREA,TRANS_CURBSIDE_STREAM,TRANS_ANNUAL_REPORTING_GROUP,TRANS_ANNUAL_REPORTING_SOURCE,TRANS_SERVICE_AREA")] Transaction transaction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transaction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(transaction);
        }

        // GET: Transactions/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Transaction == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transaction.FindAsync(id);
            if (transaction == null)
            {
                return NotFound();
            }
            return View(transaction);
        }

        // POST: Transactions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("TRANS_NUM,CUS_ID,LICENSE_PLATE,TRANS_COMPLETION_DATE,TRANS_COMPLETION_TIME,TRANS_LOAD_NUM,TRANS_NETWEIGHT,TRANS_TOTALPRICE,TRANS_HAULER,TRANS_DRIVER_EXEMPT_STATUS,VALID_IMPORT_CODE,TRANS_CONTRACT,TRANS_OPERATION,TRANS_STATUS,TRANS_ISMANUAL,TRANS_HASEXCEPTION,TRANS_SOURCE_TYPE,TRANS_ADJUSTED_PRICE,TRANS_FACILITY_CODE,TRANS_TONNES,TRANS_CUBIC_METERS,TRANS_IN_SERVICE_AREA,TRANS_ASC_NON_ASC,TRANS_FUNCTION,TRANS_CURBSIDE_AREA,TRANS_CURBSIDE_STREAM,TRANS_ANNUAL_REPORTING_GROUP,TRANS_ANNUAL_REPORTING_SOURCE,TRANS_SERVICE_AREA")] Transaction transaction)
        {
            if (id != transaction.TRANS_NUM)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transaction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransactionExists(transaction.TRANS_NUM))
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
            return View(transaction);
        }

        // GET: Transactions/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Transaction == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transaction
                .FirstOrDefaultAsync(m => m.TRANS_NUM == id);
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        // POST: Transactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Transaction == null)
            {
                return Problem("Entity set 'RDKSDatabaseContext.Transaction'  is null.");
            }
            var transaction = await _context.Transaction.FindAsync(id);
            if (transaction != null)
            {
                _context.Transaction.Remove(transaction);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransactionExists(string id)
        {
          return (_context.Transaction?.Any(e => e.TRANS_NUM == id)).GetValueOrDefault();
        }
    }
}
