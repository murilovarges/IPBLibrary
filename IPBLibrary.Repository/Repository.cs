using System.Text.Json;

namespace IPBLibrary.Repository
{
    public class Repository<T> where T : class
    {
        private readonly string _filePath;

        public Repository(string filePath)
        {
            _filePath = filePath;

            // Garante que o arquivo existe
            if (!File.Exists(_filePath))
            {
                var file = new FileInfo(filePath);
                file.Directory?.Create();  
                File.WriteAllText(_filePath, "[]");
            }
        }

        public List<T> GetAll()
        {
            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
        }

        public T? GetById(Func<T, bool> predicate){
            return GetAll().FirstOrDefault(predicate);
        }

        public void Add(T entity){
            var entities = GetAll();
            entities.Add(entity);
            SaveToFile(entities);
        }

        public void Update(Func<T, bool> predicate, T updatedEntity){
            var entities = GetAll();
            var index = entities.FindIndex(new Predicate<T>(predicate)); 

            if (index >= 0){
                entities[index] = updatedEntity;
                SaveToFile(entities);
            }
        }

        public void Delete(Func<T, bool> predicate){
            var entities = GetAll();
            var entityToRemove = entities.FirstOrDefault(predicate);

            if (entityToRemove != null){
                entities.Remove(entityToRemove);
                SaveToFile(entities);
            }
        }

        private void SaveToFile(List<T> entities){
            var json = JsonSerializer.Serialize(entities, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }
    }
}