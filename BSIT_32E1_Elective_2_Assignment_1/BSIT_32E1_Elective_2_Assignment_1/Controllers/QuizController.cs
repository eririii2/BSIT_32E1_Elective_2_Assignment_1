using Microsoft.AspNetCore.Mvc;
using BSIT_32E1_Elective_2_Assignment_1.Models;

namespace BSIT_32E1_Elective_2_Assignment_1.Controllers
{
    public class QuizController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = new QuizViewModel();

            model.Questions = new List<Question>
            {
                new Question
                {
                    Id = 1,

                    Text = "What is the fundamental difference between Server-Side Rendering (SSR/MVC) and a Decoupled Web API architecture?",

                    Choices = new List<string>
                    {
                        "A. SSR returns JSON payloads, whereas a Web API compiles .cshtml Razor views on the server[1].",
                        "B. SSR compiles HTML views on the server and sends fully rendered markup to the browser, whereas a Web API acts as a stateless data provider returning raw JSON[1].",
                        "C. SSR only works with mobile applications, whereas Web APIs are restricted to desktop web browsers[1].",
                        "D. SSR requires client-side routing in React, whereas Web APIs manage HTML layouts directly on the server[1]."
                    },

                    SelectedAnswer = "B"
                },

                new Question
                {
                    Id = 2,

                    Text = "Why do Web API controllers in ASP.NET Core inherit from ControllerBase instead of Controller?",

                    Choices = new List<string>
                    {
                        "A. ControllerBase supports Razor View rendering using View() and ViewData[2].",
                        "B. ControllerBase provides essential HTTP handling and routing without carrying unnecessary HTML view rendering overhead[1][2].",
                        "C. Controller is obsolete in .NET 8 and cannot handle HTTP POST requests[1].",
                        "D. ControllerBase automatically creates SQLite database files on application startup[2]."
                    },

                    SelectedAnswer = "B"
                },

                new Question
                {
                    Id = 3,
                    Text = "Which framework attribute automatically triggers an HTTP 400 Bad Request response when incoming request payloads fail structural model validation?",
                    Choices = new List<string>
                    {
                        "A. [Route][2]",
                        "B. [HttpGet][3]",
                        "C. [ApiController][1][2]",
                        "D. [FromQuery][2]"
                    },
                    SelectedAnswer = "C"
                },

                new Question
                {
                    Id = 4,
                    Text = "Which HTTP status code should an API return after successfully creating a new resource via a POST request, along with a Location header pointing to the new URI?",
                    Choices = new List<string>
                    {
                        "A. 200 OK[3]",
                        "B. 201 Created[1][3]",
                        "C. 204 No Content[3]",
                        "D. 404 Not Found[3]"
                    },
                    SelectedAnswer = "B"
                },

                new Question
                {
                    Id = 5,
                    Text = "When a DELETE request successfully removes a resource from the server and returns no content in the response body, which HTTP status code is standard?",
                    Choices = new List<string>
                    {
                        "A. 200 OK[3]",
                        "B. 201 Created[1][3]",
                        "C. 204 No Content[3]",
                        "D. 404 Not Found[3]"
                    },
                    SelectedAnswer = "C"
                },

                new Question
                {
                    Id = 6,
                    Text = "Which of the following endpoint URIs follows RESTful resource-oriented naming best practices?",
                    Choices = new List<string>
                    {
                        "A. GET /api/getAllCourses[3]",
                        "B. GET /api/courses[3]",
                        "C. POST /api/createNewCourseRecord[3]",
                        "D. POST /api/deleteCourseById?id=5[3]"
                    },
                    SelectedAnswer = "A"
                },

                new Question
                {
                    Id = 7,
                    Text = "What is the primary function of the [Route(\"api/[controller]\")] attribute in ASP.NET Core?",
                    Choices = new List<string>
                    {
                        "A. It connects the controller directly to an Entity Framework database context[2].",
                        "B. It maps incoming URI request paths to the controller class using the class name token[1][2].",
                        "C. It encrypts all incoming JSON payloads[2].",
                        "D. It enables Cross-Origin Resource Sharing (CORS) for external React apps[2]."
                    },
                    SelectedAnswer = "B"
                },

                new Question
                {
                    Id = 8,
                    Text = "Which HTTP verb is safe and idempotent, intended exclusively for retrieving resource data without altering server state?",
                    Choices = new List<string>
                    {
                        "A. POST[3]",
                        "B. PUT[3]",
                        "C. GET[1][3]",
                        "D. DELETE[3]"
                    },
                    SelectedAnswer = "C"
                }
            };

            return View(model);
        }
    }
}