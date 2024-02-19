﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        void ApplyForMaterial(Person person);

        List<Person> GetAll();

        bool CheckPerson(Person person);
    }
}
