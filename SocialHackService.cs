using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SocialHackApi.Models;

namespace SocialHackApi
{
    public class SocialHackService
    {
        private readonly SocialHackContext _context;

        public SocialHackService(SocialHackContext context)
        {
            _context = context;
        }
        public async Task<CityObject> LoadCityObject(long id)
        {
            var entity =  await _context.CityObjects.FirstOrDefaultAsync(x => x.Id == id);
            return entity;
        }
        public async Task<District> LoadDistrict(long id)
        {
            var entity =  await _context.Districts.FirstOrDefaultAsync(x => x.Id == id);
            return entity;
        }
        public async Task<CityTask> LoadCityTask(long id)
        {
            var entity =  await _context.CityTasks.FirstOrDefaultAsync(x => x.Id == id);
            return entity;
        }

        public async Task<DisabilityType> LoadDisabilityType(long id)
        {
            var entity = await _context.DisabilityTypes.FirstOrDefaultAsync(x => x.Id == id);
            return entity;
        }
        public async Task<List<DisabilityType>> LoadDisabilityTypes()
        {
            var entities = await _context.DisabilityTypes.ToListAsync();
            return entities;
        }
        public async Task<List<CityTask>> LoadCityTasks()
        {
            var entities = await _context.CityTasks
                .FromSqlRaw(
                    "select city_tasks.*, sum(pc.points+oc.points)*count(of.id) as sum from city_tasks\nleft join city_objects co on city_tasks.object_id = co.id\nleft join object_feedback of on co.id = of.object_id\nleft join object_categories oc on co.object_category_id = oc.id\nleft join task_place_categories tpe on city_tasks.id = tpe.task_id\nleft join place_categories pc on tpe.place_category_id = pc.id\ngroup by city_tasks.id\norder by sum(pc.points+oc.points)*count(of.id) desc;").ToListAsync();
            return entities;
        }
        public async Task<List<ObjectFeedback>> LoadFeedbacks()
        {
            var entities = await _context.ObjectFeedbacks.FromSqlRaw(
                    "select object_feedback.*, sum(oc.points+pc.points+ft.points) from object_feedback\nleft join feedback_types ft on object_feedback.feedback_type_id = ft.id\nleft join city_objects co on object_feedback.object_id = co.id\nleft join object_categories oc on co.object_category_id = oc.id\nleft join place_elements pe on object_feedback.place_element_id = pe.id\nleft join place_categories pc on pe.category_id = pc.id\ngroup by object_feedback.id\norder by sum(oc.points+pc.points+ft.points) desc;")
                .ToListAsync();
            return entities;
        }
        public async Task<List<CityObject>> LoadObjectsByWeight()
        {
            var entities = await _context.CityObjects.FromSqlRaw(
                    "select co.*, sum(oc.points+pc.points+ft.points) from city_objects co\nleft join object_feedback o on co.id = o.object_id\nleft join feedback_types ft on o.feedback_type_id = ft.id\nleft join object_categories oc on co.object_category_id = oc.id\nleft join place_elements pe on o.place_element_id = pe.id\nleft join place_categories pc on pe.category_id = pc.id\ngroup by co.id\nhaving coalesce(sum(oc.points+pc.points+ft.points),0) > 0\norder by sum(oc.points+pc.points+ft.points) desc;")
                .ToListAsync();
            return entities;
        }

        public async Task AddFeedback(ObjectFeedback feedback)
        {
            await _context.ObjectFeedbacks.AddAsync(feedback);
            await _context.SaveChangesAsync();
        }

        public async Task AddScore(ObjectScore objectScore)
        {
            await _context.ObjectScores.AddAsync(objectScore);
            await _context.SaveChangesAsync();
        }
        public async Task AddTask(CityTask cityTask)
        {
            await _context.CityTasks.AddAsync(cityTask);
            await _context.SaveChangesAsync();
        }
    }
}