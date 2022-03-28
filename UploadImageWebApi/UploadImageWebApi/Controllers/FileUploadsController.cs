﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UploadImageWebApi.Models;

namespace UploadImageWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadsController : ControllerBase
    {
       
            public static IWebHostEnvironment _webHostEnvironment;
            public FileUploadsController(IWebHostEnvironment webHostEnvironment)
            {
                _webHostEnvironment = webHostEnvironment;
            }
            [HttpPost]
            public async Task<string> Post([FromForm] FileUpload fileUpload)
            {
                try
                {
                    if (fileUpload.files.Length > 0)
                    {
                        string path = _webHostEnvironment.WebRootPath + "\\uploads\\";
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        using (FileStream fileStream = System.IO.File.Create(path + fileUpload.files.FileName))
                        {
                            fileUpload.files.CopyTo(fileStream);
                            fileStream.Flush();
                            return "Upload Done.";
                        }
                    }
                    else
                    {
                        return "Failed.";
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            [HttpGet("{fileName}")]
            public async Task<IActionResult> Get([FromRoute] string fileName)
            {
                string path = _webHostEnvironment.WebRootPath + "\\uploads\\";
                var filePath = path + fileName + ".jpg";
                if (System.IO.File.Exists(filePath))
                {
                    byte[] b = System.IO.File.ReadAllBytes(filePath);
                    return File(b, "image/jpg");
                }
                return null;
            }
        }
    }

