using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageService.Common.Contans
{
    public struct MessageCodes
    {
        public static readonly string ArgumentException = "Error en parámetros recibidos.";
        public static readonly string EmptyCollections = "No se encontraron registros para mostrar o procesar!";
        public static readonly string ErrorCreating = "Se ha producido un error en la creación del registro!";
        public static readonly string ErrorUpdating = "Se ha producido un error en la actualización del registro!";
        public static readonly string ErrorDeleting = "Se ha producido un error al eliminar el registro!";
        public static readonly string RecordExist = "Ya existe un registro con estos Datos!";
    }
}
