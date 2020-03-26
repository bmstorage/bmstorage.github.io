using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BMStorage.Data;
using BMStorage.Models;

namespace BMStorage.Controllers
{
    public class ContractsController : Controller
    {
        private readonly BMStorageContext _context;

        public ContractsController(BMStorageContext context)
        {
            _context = context;
        }

        // GET: Contracts
        public async Task<IActionResult> Index()
        {
            var bMStorageContext = _context.Contract.Include(c => c.Employee).Include(c => c.Tenant).Include(c => c.Unit);
            return View(await bMStorageContext.ToListAsync());
        }

        // GET: Contracts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contract = await _context.Contract
                .Include(c => c.Employee)
                .Include(c => c.Tenant)
                .Include(c => c.Unit)
                .FirstOrDefaultAsync(m => m.ContractID == id);
            if (contract == null)
            {
                return NotFound();
            }

            return View(contract);
        }

        // GET: Contracts/Create
        public IActionResult Create()
        {
            ViewData["EmployeeID"] = new SelectList(_context.User, "UserID", "UserID");
            ViewData["TenantID"] = new SelectList(_context.User, "UserID", "UserID");
            ViewData["UnitID"] = new SelectList(_context.Unit, "UnitID", "UnitID");
            return View();
        }

        // POST: Contracts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ContractID,UnitID,TenantID,EmployeeID,StartDate,EndDate")] Contract contract)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contract);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmployeeID"] = new SelectList(_context.User, "UserID", "UserID", contract.EmployeeID);
            ViewData["TenantID"] = new SelectList(_context.User, "UserID", "UserID", contract.TenantID);
            ViewData["UnitID"] = new SelectList(_context.Unit, "UnitID", "UnitID", contract.UnitID);
            return View(contract);
        }

        // GET: Contracts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contract = await _context.Contract.FindAsync(id);
            if (contract == null)
            {
                return NotFound();
            }
            ViewData["EmployeeID"] = new SelectList(_context.User, "UserID", "UserID", contract.EmployeeID);
            ViewData["TenantID"] = new SelectList(_context.User, "UserID", "UserID", contract.TenantID);
            ViewData["UnitID"] = new SelectList(_context.Unit, "UnitID", "UnitID", contract.UnitID);
            return View(contract);
        }

        // POST: Contracts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ContractID,UnitID,TenantID,EmployeeID,StartDate,EndDate")] Contract contract)
        {
            if (id != contract.ContractID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contract);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContractExists(contract.ContractID))
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
            ViewData["EmployeeID"] = new SelectList(_context.User, "UserID", "UserID", contract.EmployeeID);
            ViewData["TenantID"] = new SelectList(_context.User, "UserID", "UserID", contract.TenantID);
            ViewData["UnitID"] = new SelectList(_context.Unit, "UnitID", "UnitID", contract.UnitID);
            return View(contract);
        }

        // GET: Contracts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contract = await _context.Contract
                .Include(c => c.Employee)
                .Include(c => c.Tenant)
                .Include(c => c.Unit)
                .FirstOrDefaultAsync(m => m.ContractID == id);
            if (contract == null)
            {
                return NotFound();
            }

            return View(contract);
        }

        // POST: Contracts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contract = await _context.Contract.FindAsync(id);
            _context.Contract.Remove(contract);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContractExists(int id)
        {
            return _context.Contract.Any(e => e.ContractID == id);
        }
    }
}
