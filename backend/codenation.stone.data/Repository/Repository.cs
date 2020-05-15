using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Classe Repository responsavel pela manipulacao dos dados no banco de dado
/// </summary>
namespace codenation.stone.data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        private readonly DbSet<T> _dbSet;
        public Repository(ApplicationDbContext db)
        {
            _db = db;
            _dbSet = db.Set<T>();
        }
        /// <summary>
        /// Recupera um registro do banco de dados
        /// </summary>
        /// <param name="Id"> Id do registro que deve ser recuperado </param>
        /// <returns> Retorna o registro que foi encontrado </returns>
        public T Get(Guid Id)
        {
            return _dbSet.Find(Id);
        }

        /// <summary>
        /// Recupera todos os registros de uma tabela do banco de dados
        /// </summary>
        /// <returns> Registros que foram encontrados </returns>
        public IEnumerable<T> GetAll()
        {
            return _dbSet;
        }

        /// <summary>
        /// Cadastra um novo registro no banco de dados
        /// </summary>
        /// <param name="Model"> Registro que deve ser salvo no banco de dados </param>
        public void Create(T Model)
        {
            _dbSet.Add(Model);
            SaveChanges();
        }

        /// <summary>
        /// Atualiza um registro no banco de dados
        /// </summary>
        /// <param name="Model"> Registro que deve ser atualizado no banco de dados </param>
        public void Update(T Model)
        {
            _db.Entry(Model).State = EntityState.Modified;
            SaveChanges();
        }

        /// <summary>
        /// Exclui um registro do banco de dados
        /// </summary>
        /// <param name="Model"> Registro que deve ser excluido no banco de dados </param>
        public void Delete(T Model)
        {
            _db.Remove(Model);
            SaveChanges();
        }

        /// <summary>
        /// Salva as alterações realizadas no banco de dados
        /// </summary>
        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
