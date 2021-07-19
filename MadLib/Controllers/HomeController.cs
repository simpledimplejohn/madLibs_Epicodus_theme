using Microsoft.AspNetCore.Mvc;
using MadLib.Models;

namespace MadLib.Controllers
{
  public class HomeController : Controller
  {
    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/themadlib")]
    public ActionResult TheMadLib(
      string nameOne,
      string nameTwo,
      string nameThree,
      string companyOne,
      string companyTwo,
      string companyThree,
      string jobOneAdj,
      string jobTwoAdj,
      string jobThreeAdj,
      string bootCamp
      )
    {
      MadLibVariable myMadLibVariable = new MadLibVariable();
      myMadLibVariable.NameOne = nameOne;  //left side references MadLibVariable.cs, right side ref Form.cshtml
      myMadLibVariable.NameTwo = nameTwo;
      myMadLibVariable.NameThree = nameThree;
      myMadLibVariable.CompanyOne = companyOne;
      myMadLibVariable.CompanyTwo = companyTwo;
      myMadLibVariable.CompanyThree = companyThree;
      myMadLibVariable.JobOneAdj = jobOneAdj;
      myMadLibVariable.JobTwoAdj = jobTwoAdj;
      myMadLibVariable.JobThreeAdj = jobThreeAdj;
      myMadLibVariable.BootCamp = bootCamp;

      return View(myMadLibVariable);
    }
  }
}