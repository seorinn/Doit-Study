using Microsoft.AspNetCore.Mvc;
using StudentManager.Data.Services;
using StudentManager.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentManager.Data.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestScoresController : ControllerBase
    {
        private readonly TestScoreService _testScoreTest;

        public TestScoresController(TestScoreService testScoreTest)
        {
            _testScoreTest = testScoreTest;
        }

        [HttpGet]
        public async Task<ActionResult<List<TestScore>>> GetAsync(){
            /*students =  _testScoreTest.GetStudentsAsync();
            return students;*/
            //Service의 Scores를 Return
        }

        [HttpGet("{id:length(24)}", Name = "GetTestScore")]
        public async Task<ActionResult<TestScore>> GetAsync(string id)
        {
            /*student = _testScoreTest.GetAsync(id);
            if(student == DBID){
                return null;
            }
            else if(student == DBID){
                return student.score;
            }*/
            //파라미터 ID를 DB Id로 갖는 Score를 Return
        }

        [HttpGet("testscoreId={id:length(4)}")]
        public async Task<ActionResult<TestScore>> GetByIdAsync(string id)
        {
            /*student = _testScoreTest.GetAsync(id);
            if(student == StudentID){
                return null;
            }
            else if(student == StudentID){
                return student.score;
            }*/
            //파라미터 ID를 StudentId로 갖는 Score를 Return
        }

        [HttpPost]
        public async Task<ActionResult<TestScore>> CreateAsync(TestScore_Dto scoreDto)
        {
            //return ;
            //파라미터 Score를 DB에 생성.
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> UpdateAsync(string id, TestScore_Dto scoreDtoIn)
        {
            //return ;
            //파라미터 ID를 DB Id로 갖는 Score를 scoreDtoIn내용으로 업테이트.
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> DeleteAsync(string id)
        {
            //return ;
            //파라미터 ID를 DB Id로 갖는 Score를 제거.
        }
    }
}