using System;
using System.Reflection;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Tool.hbm2ddl;

namespace MinhaEmpresa.SharedKernel.Repositorio
{
    public static class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory()
        {
            if (_sessionFactory != null) return _sessionFactory;

            var config = new Configuration().Configure(GetPath() + "\\nhibernate.cfg.xml");
            _sessionFactory = config.BuildSessionFactory();
            return _sessionFactory;
        }

        public static string GetPath()
        {
            var x = new Uri(Assembly.GetExecutingAssembly().CodeBase);
            var path = x.LocalPath.ToLower().Replace("\\minhaempresa.sharedkernel.repositorio.dll", "");
            return path;
        }

        public static ISession OpenSession()
        {
            return SessionFactory().OpenSession();
        }

        public static void CreateDb()
        {
            var config = new Configuration().Configure(GetPath() + "\\nhibernate.cfg.xml");
            var schemaExport = new SchemaExport(config);
            schemaExport.Drop(true, false);
            schemaExport.Create(true, true);
        }
    }
}