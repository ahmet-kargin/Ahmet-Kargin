using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class JobManager
    {
        public string UploadImage(IFormFile file)
        {
            var extension = Path.GetExtension(file.FileName);
            var randomName = string.Format($"{Guid.NewGuid()}-{extension}");
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", randomName);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            return randomName;
        }
    }
}
