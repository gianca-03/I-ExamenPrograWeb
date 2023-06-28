using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Helpers
{
    public class ProveedorHelper
    {
        ServiceRepository repository;

        public ProveedorHelper()
        {
            repository = new ServiceRepository();
        }

        public List<ProveedorViewModel> GetAll()
        {

            List<ProveedorViewModel> lista = new List<ProveedorViewModel>();
            HttpResponseMessage responseMessage = repository.GetResponse("api/proveedor/");
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                lista = JsonConvert.DeserializeObject<List<ProveedorViewModel>>(content);
            }

            return lista;
        }

        public ProveedorViewModel GetById(int id)
        {
            ProveedorViewModel proveedor = new ProveedorViewModel();

            HttpResponseMessage responseMessage = repository.GetResponse("api/proveedor/" + id);
            var content = responseMessage.Content.ReadAsStringAsync().Result;

            proveedor = JsonConvert.DeserializeObject<ProveedorViewModel>(content);

            return proveedor;
        }

        public ProveedorViewModel Edit(ProveedorViewModel proveedor)
        {

            HttpResponseMessage responseMessage = repository.PutResponse("api/proveedor/", proveedor);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            ProveedorViewModel proveedorAPI = JsonConvert.DeserializeObject<ProveedorViewModel>(content);
            return proveedorAPI;
        }

        public ProveedorViewModel Add(ProveedorViewModel proveedor)
        {

            HttpResponseMessage responseMessage = repository.PostResponse("api/proveedor/", proveedor);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            ProveedorViewModel proveedorAPI = JsonConvert.DeserializeObject<ProveedorViewModel>(content);
            return proveedorAPI;
        }

        public ProveedorViewModel Delete(int id)
        {
            ProveedorViewModel proveedor = new ProveedorViewModel();

            HttpResponseMessage responseMessage = repository.DeleteResponse("api/proveedor/" + id);
            // string content = responseMessage.Content.ReadAsStringAsync().Result;
            // category = JsonConvert.DeserializeObject<CategoryViewModel>(content);

            return proveedor;
        }

    }
}
