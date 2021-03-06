﻿using RegistroDeBiblias.DAL;
using RegistroDeBiblias.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeBiblias.BLL
{
   public class LibrosBll
    {
        public static bool Guardar(Libros libro)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Libros.Add(libro) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public static bool Modificar(Libros libro)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(libro).State = EntityState.Modified;
                if(contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Eliminar(object id)
        {
            throw new NotImplementedException();
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                Libros libro = contexto.Libros.Find(id);
                contexto.Libros.Remove(libro);
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();

            }catch(Exception)
            {
                throw;
            }
            return paso;
            
        }
        public static Libros Buscar(int id)
        {
            
            Contexto contexto = new Contexto();
            Libros libro = new Libros();
            try
            {
                libro = contexto.Libros.Find(id);
                contexto.Dispose();

            }
            catch (Exception)
            {
                throw;
            }
            return libro;

        }
        public static List<Libros> GetList(Expression<Func<Libros, bool>> expression)
        {
            List<Libros> libros = new List<Libros>();
            Contexto contexto = new Contexto();
            try
            {
                libros = contexto.Libros.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }

            return libros;
        }





    }
}
