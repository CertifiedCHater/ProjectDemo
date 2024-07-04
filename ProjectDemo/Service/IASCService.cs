using ProjectDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo.Service;

interface IASCService
{
    Task<List<Data>> GetArts();
}
