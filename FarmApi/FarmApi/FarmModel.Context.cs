﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FarmApi
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class FarmEntities : DbContext
    {
        public FarmEntities()
            : base("name=FarmEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual int AddHarvestedQuantityByWorker(string qRCode, Nullable<double> quantity, string username)
        {
            var qRCodeParameter = qRCode != null ?
                new ObjectParameter("QRCode", qRCode) :
                new ObjectParameter("QRCode", typeof(string));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(double));
    
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddHarvestedQuantityByWorker", qRCodeParameter, quantityParameter, usernameParameter);
        }
    
        public virtual int AddPlantation(string harvest, Nullable<int> plantationID)
        {
            var harvestParameter = harvest != null ?
                new ObjectParameter("Harvest", harvest) :
                new ObjectParameter("Harvest", typeof(string));
    
            var plantationIDParameter = plantationID.HasValue ?
                new ObjectParameter("PlantationID", plantationID) :
                new ObjectParameter("PlantationID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddPlantation", harvestParameter, plantationIDParameter);
        }
    
        public virtual int AddUser(string username, string password, string name, string cNP, string addess, string email, Nullable<int> userID)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var cNPParameter = cNP != null ?
                new ObjectParameter("CNP", cNP) :
                new ObjectParameter("CNP", typeof(string));
    
            var addessParameter = addess != null ?
                new ObjectParameter("Addess", addess) :
                new ObjectParameter("Addess", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddUser", usernameParameter, passwordParameter, nameParameter, cNPParameter, addessParameter, emailParameter, userIDParameter);
        }
    
        public virtual int AddWorker(string name, string qRCode)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var qRCodeParameter = qRCode != null ?
                new ObjectParameter("QRCode", qRCode) :
                new ObjectParameter("QRCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddWorker", nameParameter, qRCodeParameter);
        }
    
        public virtual int DeletePlantation(Nullable<int> plantationID)
        {
            var plantationIDParameter = plantationID.HasValue ?
                new ObjectParameter("PlantationID", plantationID) :
                new ObjectParameter("PlantationID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeletePlantation", plantationIDParameter);
        }
    
        public virtual int DeleteUser(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteUser", usernameParameter);
        }
    
        public virtual int DeleteWorker(string qRCode)
        {
            var qRCodeParameter = qRCode != null ?
                new ObjectParameter("QRCode", qRCode) :
                new ObjectParameter("QRCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteWorker", qRCodeParameter);
        }
    
        public virtual ObjectResult<GetAllPlantations_Result> GetAllPlantations()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllPlantations_Result>("GetAllPlantations");
        }
    
        public virtual ObjectResult<GetAllUsers_Result> GetAllUsers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllUsers_Result>("GetAllUsers");
        }
    
        public virtual ObjectResult<GetAllWorkers_Result> GetAllWorkers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllWorkers_Result>("GetAllWorkers");
        }
    
        public virtual ObjectResult<GetPlantationByUserID_Result> GetPlantationByUserID(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetPlantationByUserID_Result>("GetPlantationByUserID", userIDParameter);
        }
    
        public virtual ObjectResult<GetQuantitiesByWorker_Result> GetQuantitiesByWorker(string qRCode)
        {
            var qRCodeParameter = qRCode != null ?
                new ObjectParameter("QRCode", qRCode) :
                new ObjectParameter("QRCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetQuantitiesByWorker_Result>("GetQuantitiesByWorker", qRCodeParameter);
        }
    
        public virtual ObjectResult<Nullable<double>> GetTotalQuantityByWorker(string qRCode)
        {
            var qRCodeParameter = qRCode != null ?
                new ObjectParameter("QRCode", qRCode) :
                new ObjectParameter("QRCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<double>>("GetTotalQuantityByWorker", qRCodeParameter);
        }
    
        public virtual int UpdatePlantation(Nullable<int> plantationID, string harvest)
        {
            var plantationIDParameter = plantationID.HasValue ?
                new ObjectParameter("PlantationID", plantationID) :
                new ObjectParameter("PlantationID", typeof(int));
    
            var harvestParameter = harvest != null ?
                new ObjectParameter("Harvest", harvest) :
                new ObjectParameter("Harvest", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdatePlantation", plantationIDParameter, harvestParameter);
        }
    
        public virtual int UpdateUser(Nullable<int> userID, string username, string password, string name, string cNP, string addess, string email)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var cNPParameter = cNP != null ?
                new ObjectParameter("CNP", cNP) :
                new ObjectParameter("CNP", typeof(string));
    
            var addessParameter = addess != null ?
                new ObjectParameter("Addess", addess) :
                new ObjectParameter("Addess", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateUser", userIDParameter, usernameParameter, passwordParameter, nameParameter, cNPParameter, addessParameter, emailParameter);
        }
    }
}
