//N. Harrison Wilkins
//10-26-2022
//ASKING QUESTIONS - ENDPOINTS
//THIS PROGRAM WILL RUN THROUGH A WEB API AN ALLOW THE USER TO INPUT THEIR NAME AND THE TIME THAT THEY WOKE UP, THEN GETTING AN ANSWER ACCORDING TO THEIR INPUT
//PEER REVIEW BY : Jacob Dekok - The code looks clean and organized. The program runs as intended

using Microsoft.AspNetCore.Mvc;

namespace WilkinsHAskingQuestions_Endpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class QuestionController : ControllerBase
{
    [HttpGet]
    [Route ("greeting/{userName}/{userTime}")]
    public string AskingQuestions(string userName, string userTime)
    {
        return $"GREETINGS {userName}, {userTime} SURE IS EARLY!!";
    }
}
