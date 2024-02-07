using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piggy.models
{
    public class UserModel
    {
    public int Id { get; set; }
    public string UserName { get; set; }
    public int UserType { get; set; }
    public string UserPassword { get; set; }
    public DateTime UserCreationDate { get; set; }

    }
}
