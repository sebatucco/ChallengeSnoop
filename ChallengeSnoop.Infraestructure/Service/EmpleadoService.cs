using ChallengeSnopp.Core.DTOs;
using ChallengeSnopp.Core.Entities;
using ChallengeSnopp.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeSnoop.Infraestructure.Service
{
    public class EmpleadoService : IEmpleadoService
    {

        private readonly IUnitOfWork _unitOfWork;

        public EmpleadoService(IUnitOfWork unitOfWork)
        { 
           _unitOfWork = unitOfWork;
        }

        public async Task<Empleado> Add(EmpleadoDTO empleado)
        {
            var Empleado = new Empleado
            {
               Apellido = empleado.Apellido,
               Nombre = empleado.Nombre,
               Dni = empleado.Dni,
               FechaNacimiento = empleado.FechaNacimiento,
               FechaIngreso = empleado.FechaIngreso
            };
           return  await _unitOfWork.EmpleadoRespository.Add(Empleado);
        }

        public async Task<List<Empleado>> AntiguedadEmpleado(string antiguedad)
        {

            var antiguedadEmpleados = await _unitOfWork.EmpleadoRespository.Antiguedad(RomanToInt(antiguedad));
            return antiguedadEmpleados.ToList();
        }

        public async  Task DeleteByIdAsync(int id)
        {
           await _unitOfWork.EmpleadoRespository.DeleteByIdAsync(id);
        }

        public async Task<List<Empleado>> GetAllAsync()
        {
            var empleados = await _unitOfWork.EmpleadoRespository.GetAllAsync();
            return empleados.ToList(); 
        }

        public async Task<Empleado> GetByIdAsync(int id)
        {
           return await _unitOfWork.EmpleadoRespository.GetByIdAsync(id);
        }

        public async Task<Empleado> Update(Empleado empleado)
        {
            var empledoUpdate = await GetByIdAsync(empleado.Id);
            if (empledoUpdate != null) 
            {

                empledoUpdate.Apellido = empleado.Apellido;
                empledoUpdate.Nombre = empleado.Nombre;
                empledoUpdate.Dni = empleado.Dni;
                empledoUpdate.FechaNacimiento = empleado.FechaNacimiento;
                empledoUpdate.FechaIngreso = empleado.FechaIngreso;
                return await _unitOfWork.EmpleadoRespository.Update(empledoUpdate);
            }

            return null;
          
        }

        public int RomanToInt(string s)
        {
            int sum = 0;
            Dictionary<char, int> romanNumbersDictionary = new()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
            for (int i = 0; i < s.Length; i++)
            {
                char currentRomanChar = s[i];
                romanNumbersDictionary.TryGetValue(currentRomanChar, out int num);
                if (i + 1 < s.Length && romanNumbersDictionary[s[i + 1]] > romanNumbersDictionary[currentRomanChar])
                {
                    sum -= num;
                }
                else
                {
                    sum += num;
                }
            }
            
            return sum;
        }
    }
}
