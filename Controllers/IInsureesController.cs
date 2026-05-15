using CarInsurance.Models;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public interface IInsureesController
    {
        ActionResult Admin();
        ActionResult Create();
        ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree);
        ActionResult Delete(int? id);
        ActionResult DeleteConfirmed(int id);
        ActionResult Details(int? id);
        ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree);
        ActionResult Edit(int? id);
        ActionResult Index();
    }
}