using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using P1MOVIL2.Models;
using System.Threading.Tasks;

namespace P1MOVIL2.Models
{
    public class EmpleDB
    {
        readonly SQLiteAsyncConnection db;
        //Constructor de clase vacio
        public EmpleDB()
        {

        }
        //Constructor con parametros
        public EmpleDB(String pathbasedatos)
        {
            db = new SQLiteAsyncConnection(pathbasedatos);
            // Creacion de tablas de base de datos
            db.CreateTableAsync<Empleados>();
        }
        //Procedimientos y Funciones necesarios
        //Retorna la tabla de empleados con una lista
        public Task<List<Empleados>> listaempleados()
        {
            return db.Table<Empleados>().ToListAsync();
        }
        //Buscar un empleado especifico por el codigo
        public Task<Empleados> ObtenerEmpleado(Int32 pcodigo)
        {
            return db.Table<Empleados>()
                .Where(i => i.codigo == pcodigo)
                .FirstOrDefaultAsync();
        }      

        //Guardar o Actualizar Empleado
       
        public Task<Int32> EmpleadoGuardar(Empleados emple)
        {
                if(emple.codigo !=0)
                {
                return db.UpdateAsync(emple); 
                }
                else
                {
                return db.InsertAsync(emple);
                }
        }
        //Eliminar Empleado
        public Task<Int32> EmpleadoBorrar(Empleados emple)
        {
            return db.DeleteAsync(emple);
        }

        internal void ObtenerEmpleado()
        {
            throw new NotImplementedException();
        }
        public Task<List<Empleados>> GetEmpleados()
        {
            return db.Table<Empleados>().ToListAsync();
        }
        public Task<Empleados> GetEmpleadosByIdAsync(int pcodigo)
        {
            return db.Table<Empleados>().Where(a => a.codigo == pcodigo).FirstOrDefaultAsync();
        }
    }
}
