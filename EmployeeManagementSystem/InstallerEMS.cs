using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    [RunInstaller(true)]
    public partial class InstallerEMS : System.Configuration.Install.Installer
    {
        public InstallerEMS()
        {
            InitializeComponent();
        }
    }
}
