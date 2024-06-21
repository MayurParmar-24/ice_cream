using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using System.Text.RegularExpressions;
using WebApplication2.Data;
using WebApplication2.Models;



namespace WebApplication2.Controllers
{
    public class adminController : Controller
    {

        appcontext _appcontext;
        IWebHostEnvironment env;

        public object Gallery_img { get; private set; }
        public string Product_image { get; private set; }

        public adminController(appcontext appcontext , IWebHostEnvironment environment)
        {
            _appcontext = appcontext;
            env = environment;
        }
        
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(contact c)

        {
            _appcontext.contacts.Add(c);
            _appcontext.SaveChanges();
            ModelState.Clear();
            return View();
        }

        public IActionResult viewcontact()
        {
            return View(_appcontext.contacts.ToList());
        }

        public IActionResult contactdelete(int id)
        {
            contact _contact = _appcontext.contacts.Find(id);
           
            _appcontext.SaveChanges();
            return RedirectToAction("viewcontact");
        }
        public IActionResult signup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult signup(signup c)
        {
            _appcontext.signups.Add(c);
            _appcontext.SaveChanges();
            ModelState.Clear();
            return View("login");
        }

        public IActionResult viewsignup()
        {
            return View(_appcontext.signups.ToList());
        }


        public IActionResult CartDetails()
        {
            return View(_appcontext.addtocarts.ToList());
        }


        public IActionResult cartDelete(int Id)

        {

            addtocart add = _appcontext.addtocarts.Find(Id);

            _appcontext.addtocarts.Remove(add);
            _appcontext.SaveChanges();
            return RedirectToAction("CartDetails");

        }
        public IActionResult signupDetail(int id)

        {
            var a = _appcontext.signups.Find(id);
            return View(a);
        }

        public IActionResult signupDelete(int id)
        {
            signup signup = _appcontext.signups.Find(id);
            
            _appcontext.SaveChanges();
            return RedirectToAction("viewsignup");
        }

        public IActionResult signupdate(int id)
        {
            var myresult = _appcontext.signups.Find(id);
            return View(myresult);
        }
        [HttpPost]
        public IActionResult signupdate(signup s)
        {
            var record = _appcontext.signups.Find(s.id);
            if
                (record != null)
            {
                record.name = s.name;
                record.email = s.email;
                record.password = s.password;
                record.Re_Password = s.Re_Password;
            }
            _appcontext.SaveChanges();
            return RedirectToAction("viewsignup");
        }

        public IActionResult login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult login(signup s)
        {
            var myvalue = _appcontext.signups.Where(mydata => mydata.email ==
            s.email && mydata.password == s.password).FirstOrDefault();

            if (myvalue != null)
            {
                return RedirectToAction("Dashboard");
            }
            else
            {
                ViewBag.error = "Invalid Email and Password";
            }
            return View();
        }
        

        public IActionResult feedback() { 
        
            return View();

        }

        [HttpPost]
        public IActionResult feedback(feedback c)
        {
            _appcontext.feedbacks.Add(c);
            _appcontext.SaveChanges();
            ModelState.Clear();
            return View();

        }

        public IActionResult viewfeedback()
        {
            return View(_appcontext.feedbacks.ToList());
        }
       
        public IActionResult feedbackDelete(int Id)
        {
            feedback feedback = _appcontext.feedbacks.Find(Id);
            
            _appcontext.SaveChanges();
            return RedirectToAction("viewfeedback");
        }

        public IActionResult fbupdate(int Id)
        {
            var feedbackresult = _appcontext.feedbacks.Find(Id);
            return View(feedbackresult);
        }
        [HttpPost]
        public IActionResult fbupdate(feedback s)
        {
            var record = _appcontext.feedbacks.Find(s.Id);
            if
                (record != null)
            {
                record.Name = s.Name;
                record.Email = s.Email;
                record.Message = s.Message;
               
            }
            _appcontext.SaveChanges();
            return RedirectToAction("viewfeedback");
        }

        public IActionResult gallery()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Product()
        {
            return View();
        }

        public IActionResult addtocarts()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addtocarts(addtocart a)
        {
            _appcontext.addtocarts.Add(a);
            _appcontext.SaveChanges();
            ModelState.Clear();
            return RedirectToAction("allProduct");
        }

        public IActionResult addProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult addProduct(Product_ p)
        {
            String filename = "";
            if (p.Photo != null)
            {
                String uploadFolder = Path.Combine(env.WebRootPath, "Product_img");
                filename = Guid.NewGuid().ToString() + "_" + p.Photo.FileName;
                string mergevalue = Path.Combine(uploadFolder, filename);
                p.Photo.CopyTo(new FileStream(mergevalue, FileMode.Create));

                Product data = new Product()
                { 
                Name =  p.Name, 
                 Price = p.Price,
                    Product_image = filename
                };

                _appcontext.Products.Add(data);
                _appcontext.SaveChanges();
                ModelState.Clear();
            }

            return View();
        }

        public IActionResult viewProduct()
        {

            return View(_appcontext.Products.ToList());
        }


        public IActionResult allProduct()
        {
            return View(_appcontext.Products.ToList());
        }

        public IActionResult Service()
        {
            return View();
        }

        public IActionResult Our_staff()
        {
            return View();
        }

        public IActionResult FAQs()
        {
            return View();
        }

		public IActionResult Free_recipe()
		{
			return View();
		}

        public IActionResult Dashboard()
        {
            return View();
        }


        public IActionResult addGallery()
        {
            return View();
        }

        [HttpPost]
        public IActionResult addGallery(Gallery_ g)
        {
            String filename = "";
            if(g.Photo != null)
            {
                String uploadFolder = Path.Combine(env.WebRootPath, "images");
                filename = Guid.NewGuid().ToString() + "_" + g.Photo.FileName;
                string mergevalue = Path.Combine(uploadFolder, filename);
                g.Photo.CopyTo(new FileStream(mergevalue, FileMode.Create));

                Gallery data = new Gallery()
                {
                    Gallery_img = filename,
                };

                _appcontext.galleries.Add(data);
				_appcontext.SaveChanges();
                 ModelState.Clear();      
            }

            return View();
        }

        public IActionResult viewGallery() 
        {
        
            return View(_appcontext.galleries.ToList());
        }

        
            public IActionResult GalleryDelete(int Gallery_Id)
        {
            Gallery g = _appcontext.galleries.Find(Gallery_Id);         
            return RedirectToAction("viewGallery");
        }

    }
}

