using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ApPist.Business.Abstract;
using ApPist.Domain.Concrete;
using ApPist.WebUI.Models.Gallery;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApPist.WebUI.Controllers
{
    public class GalleryController : AuthBaseController
    {
        private IImageService imageService;

        public GalleryController(IImageService _imageService)
        {
            imageService = _imageService;
        }

        public IActionResult Image()
        {
            var imageList = imageService.GetAllImage();

            var model = new ImageModel
            {
                Images = imageList
            };

            return View(model);
        }

        public IActionResult UploadFile(IFormFile file)
        {
            try
            {
                imageService.UploadFile(file);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return RedirectToAction("Image");
        }

        public IActionResult DeleteImage(Image image)
        {
            try
            {
             
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return RedirectToAction("Image");
        }
    }
}