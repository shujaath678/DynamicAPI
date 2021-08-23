using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AjaxRestAPI.Services;
using Newtonsoft.Json;
using AjaxRestAPI.Models;

namespace AjaxRestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseController : ControllerBase
    {
        private ICategoryServices _categoryService { get; set; }

        private IBaseServices _baseService { get; set; }

        public BaseController(ICategoryServices categoryService, IBaseServices baseServices)
        {
            _categoryService = categoryService;
            _baseService = baseServices;
        }

        [HttpGet]
        [Route("ajaxCall")]
        public Task<List<string>> GetWeatherReport()
        {
            return _baseService.BaseServiceMethod();
        }

        [HttpGet]
        [Route("getCategories")]
        public List<Category> GetCategories()
        {
            /*CategoryServices categoryRepository = new CategoryServices();
            List<Category> categories = categoryRepository.GetCategories();

            return categories;*/

            List<Category> categories = _categoryService.GetCategories();
            return categories;
        }
    }
}