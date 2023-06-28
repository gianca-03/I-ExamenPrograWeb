using DAL.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class ProveedorDALImpl : IProvedoresDAL
    {
        private ComercioContext comercioContext;
        private UnidadDeTrabajo<Proveedore> unidad;

        public bool Add(Proveedore entity)
        {
            try
            {
                using (unidad = new UnidadDeTrabajo<Proveedore>(new ComercioContext()))
                {
                    unidad.genericDAL.Add(entity);
                    unidad.Complete();
                }


                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public void AddRange(IEnumerable<Proveedore> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Proveedore> Find(Expression<Func<Proveedore, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Proveedore Get(int id)
        {
            Proveedore proveedor = null;
            using (unidad = new UnidadDeTrabajo<Proveedore>(new ComercioContext()))
            {
                proveedor = unidad.genericDAL.Get(id);
            }
            return proveedor;
        }

        public IEnumerable<Proveedore> GetAll()
        {
            IEnumerable<Proveedore> proveedores= null;

            using (unidad = new UnidadDeTrabajo<Proveedore>(new ComercioContext()))
            {
                proveedores = unidad.genericDAL.GetAll();
            }
            return proveedores;
        }

        public bool Remove(Proveedore entity)
        {
            try
            {
                using (unidad = new UnidadDeTrabajo<Proveedore>(new ComercioContext()))
                {
                    unidad.genericDAL.Remove(entity);
                    unidad.Complete();
                }


                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public void RemoveRange(IEnumerable<Proveedore> entities)
        {
            throw new NotImplementedException();
        }

        public Proveedore SingleOrDefault(Expression<Func<Proveedore, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(Proveedore entity)
        {
            try
            {
                using (unidad = new UnidadDeTrabajo<Proveedore>(new ComercioContext()))
                {
                    unidad.genericDAL.Update(entity);
                    unidad.Complete();
                }


                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
