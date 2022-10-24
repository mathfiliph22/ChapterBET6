﻿using ChapterBET6.Contexts;
using ChapterBET6.Interfaces;
using ChapterBET6.Models;

namespace ChapterBET6.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private readonly sqlcontext _context;
      

        public UsuarioRepository(sqlcontext context)
        {
            _context = context;
                
        }

        public void Atualizar(int id, Usuario usuario)
        {
            Usuario usuarioEncontrado = _context.Usuarios.Find(id);

            if (usuarioEncontrado != null)
            {
                usuarioEncontrado.Email = usuario.Email;
                usuarioEncontrado.Senha = usuario.Senha;
           

                _context.Usuarios.Update(usuarioEncontrado);

                _context.SaveChanges();
            }
        }

        public Usuario BuscarPorId(int id)
        {
            return _context.Usuarios.Find();
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            _context.Usuarios.Add(novoUsuario);

            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            Usuario usuario = _context.Usuarios.Find(id);

            _context.Usuarios.Remove(usuario);

            _context.SaveChanges();

        }

        public List<Usuario> Listar()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario Login(string email, string senha)
        {
            throw new NotImplementedException();
        }
    }
}
