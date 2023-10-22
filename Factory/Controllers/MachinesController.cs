using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Factory.Controllers;
public class MachinesController: Controller
{
  private readonly FactoryContext _db;
  public MachinesController(FactoryContext db)
  {
    _db = db;
  }
  public ActionResult Index()
  {
    return View(_db.Machines.ToList());
  }

  public ActionResult Details(int id)
  {
    Machine toDisplay = _db.Machines.Include(m => m.JoinEntities).ThenInclude(join => join.Engineer)
                  .FirstOrDefault(m => m.MachineId == id);
    return View(toDisplay);    
  }
  public ActionResult Create()
  {
    return View();
  }
  [HttpPost]
  public ActionResult Create(Machine machine)
  {
    _db.Machines.Add(machine);
    _db.SaveChanges();
    return RedirectToAction("Index");
  }
  public ActionResult AddEngineer(int id)
  {
    Machine toDisplay = _db.Machines.FirstOrDefault(machine => machine.MachineId == id);
    ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "Name");
    return View(toDisplay);
  }
  [HttpPost]
  public ActionResult AddEngineer(Machine machine, int engineerId)
  {
    #nullable enable
    MachineEngineer? join= _db.MachineEngineers.FirstOrDefault(join => (join.EngineerId == engineerId && join.MachineId == machine.MachineId));
    #nullable disable
    if(join == null && engineerId != 0)
    {
      _db.MachineEngineers.Add(new MachineEngineer() { EngineerId = engineerId, MachineId = machine.MachineId });
      _db.SaveChanges();
    }
    return RedirectToAction("Details", new { id = machine.MachineId });
  }

  public ActionResult Edit(int id)
  {
    Machine toEdit = _db.Machines.FirstOrDefault(machine => machine.MachineId == id);
    return View(toEdit);
  }

  [HttpPost]
  public ActionResult Edit(Machine machine)
  {
    _db.Machines.Update(machine);
    _db.SaveChanges();
    return RedirectToAction("Index");
  }

  public ActionResult Delete(int id)
  {
    Machine toDelete = _db.Machines.FirstOrDefault(machine => machine.MachineId == id);
    return View(toDelete);
  }

  [HttpPost, ActionName("Delete")]
  public ActionResult DeleteConfirmed(int id)
  {
    Machine toDelete = _db.Machines.FirstOrDefault(machine => machine.MachineId == id);
    _db.Machines.Remove(toDelete);
    _db.SaveChanges();
    return RedirectToAction("Index");
  }

  [HttpPost]
  public ActionResult DeleteJoin(int joinId)
  {
    MachineEngineer join = _db.MachineEngineers.FirstOrDefault(me => me.MachineEngineerId == joinId);
    _db.MachineEngineers.Remove(join);
    _db.SaveChanges();
    return RedirectToAction("Index");
  }

}