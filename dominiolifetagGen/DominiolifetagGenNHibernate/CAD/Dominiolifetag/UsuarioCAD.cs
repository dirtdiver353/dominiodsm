
using System;
using System.Text;
using DominiolifetagGenNHibernate.CEN.Dominiolifetag;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using DominiolifetagGenNHibernate.EN.Dominiolifetag;
using DominiolifetagGenNHibernate.Exceptions;


/*
 * Clase Usuario:
 *
 */

namespace DominiolifetagGenNHibernate.CAD.Dominiolifetag
{
public partial class UsuarioCAD : BasicCAD, IUsuarioCAD
{
public UsuarioCAD() : base ()
{
}

public UsuarioCAD(ISession sessionAux) : base (sessionAux)
{
}



public UsuarioEN ReadOIDDefault (int ID
                                 )
{
        UsuarioEN usuarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Get (typeof(UsuarioEN), ID);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DominiolifetagGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DominiolifetagGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuarioEN;
}

public System.Collections.Generic.IList<UsuarioEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(UsuarioEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<UsuarioEN>();
                        else
                                result = session.CreateCriteria (typeof(UsuarioEN)).List<UsuarioEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DominiolifetagGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DominiolifetagGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioEN usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), usuario.ID);

                usuarioEN.Nombre = usuario.Nombre;


                usuarioEN.Email = usuario.Email;


                usuarioEN.Password = usuario.Password;


                usuarioEN.Pais = usuario.Pais;


                usuarioEN.Telefono = usuario.Telefono;


                usuarioEN.Nickname = usuario.Nickname;


                usuarioEN.Fotoruta = usuario.Fotoruta;


                usuarioEN.Activacion = usuario.Activacion;


                usuarioEN.Listamegusta = usuario.Listamegusta;


                usuarioEN.Categoriassuscrito = usuario.Categoriassuscrito;


                usuarioEN.Bloqueado = usuario.Bloqueado;




                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DominiolifetagGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DominiolifetagGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();
                if (usuario.Publicacion != null) {
                        foreach (DominiolifetagGenNHibernate.EN.Dominiolifetag.PublicacionEN item in usuario.Publicacion) {
                                item.Usuario = usuario;
                                session.Save (item);
                        }
                }

                session.Save (usuario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DominiolifetagGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DominiolifetagGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuario.ID;
}

public void Modify (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioEN usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), usuario.ID);

                usuarioEN.Nombre = usuario.Nombre;


                usuarioEN.Email = usuario.Email;


                usuarioEN.Password = usuario.Password;


                usuarioEN.Pais = usuario.Pais;


                usuarioEN.Telefono = usuario.Telefono;


                usuarioEN.Nickname = usuario.Nickname;


                usuarioEN.Fotoruta = usuario.Fotoruta;


                usuarioEN.Activacion = usuario.Activacion;


                usuarioEN.Listamegusta = usuario.Listamegusta;


                usuarioEN.Categoriassuscrito = usuario.Categoriassuscrito;


                usuarioEN.Bloqueado = usuario.Bloqueado;

                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DominiolifetagGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DominiolifetagGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int ID
                     )
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioEN usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), ID);
                session.Delete (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DominiolifetagGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DominiolifetagGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
