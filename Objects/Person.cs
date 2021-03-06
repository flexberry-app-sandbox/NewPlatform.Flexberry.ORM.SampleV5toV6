//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewPlatform.SampleV5toV6
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Business.Audit;
    using ICSSoft.STORMNET.Business.Audit.Objects;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Person.
    /// </summary>
    // *** Start programmer edit section *** (Person CustomAttributes)

    // *** End programmer edit section *** (Person CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("AuditView", new string[] {
            "Name as \'Name\'"})]
    [View("PersonE", new string[] {
            "Name as \'Name\'"})]
    [View("PersonL", new string[] {
            "Name as \'Name\'"})]
    public class Person : ICSSoft.STORMNET.DataObject, IDataObjectWithAuditFields
    {
        
        private string fName;
        
        private System.Nullable<System.DateTime> fCreateTime;
        
        private string fCreator;
        
        private System.Nullable<System.DateTime> fEditTime;
        
        private string fEditor;
        
        // *** Start programmer edit section *** (Person CustomMembers)

        // *** End programmer edit section *** (Person CustomMembers)

        
        /// <summary>
        /// Name.
        /// </summary>
        // *** Start programmer edit section *** (Person.Name CustomAttributes)

        // *** End programmer edit section *** (Person.Name CustomAttributes)
        [StrLen(255)]
        public virtual string Name
        {
            get
            {
                // *** Start programmer edit section *** (Person.Name Get start)

                // *** End programmer edit section *** (Person.Name Get start)
                string result = this.fName;
                // *** Start programmer edit section *** (Person.Name Get end)

                // *** End programmer edit section *** (Person.Name Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Person.Name Set start)

                // *** End programmer edit section *** (Person.Name Set start)
                this.fName = value;
                // *** Start programmer edit section *** (Person.Name Set end)

                // *** End programmer edit section *** (Person.Name Set end)
            }
        }
        
        /// <summary>
        /// Время создания объекта.
        /// </summary>
        // *** Start programmer edit section *** (Person.CreateTime CustomAttributes)

        // *** End programmer edit section *** (Person.CreateTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> CreateTime
        {
            get
            {
                // *** Start programmer edit section *** (Person.CreateTime Get start)

                // *** End programmer edit section *** (Person.CreateTime Get start)
                System.Nullable<System.DateTime> result = this.fCreateTime;
                // *** Start programmer edit section *** (Person.CreateTime Get end)

                // *** End programmer edit section *** (Person.CreateTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Person.CreateTime Set start)

                // *** End programmer edit section *** (Person.CreateTime Set start)
                this.fCreateTime = value;
                // *** Start programmer edit section *** (Person.CreateTime Set end)

                // *** End programmer edit section *** (Person.CreateTime Set end)
            }
        }
        
        /// <summary>
        /// Создатель объекта.
        /// </summary>
        // *** Start programmer edit section *** (Person.Creator CustomAttributes)

        // *** End programmer edit section *** (Person.Creator CustomAttributes)
        [StrLen(255)]
        public virtual string Creator
        {
            get
            {
                // *** Start programmer edit section *** (Person.Creator Get start)

                // *** End programmer edit section *** (Person.Creator Get start)
                string result = this.fCreator;
                // *** Start programmer edit section *** (Person.Creator Get end)

                // *** End programmer edit section *** (Person.Creator Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Person.Creator Set start)

                // *** End programmer edit section *** (Person.Creator Set start)
                this.fCreator = value;
                // *** Start programmer edit section *** (Person.Creator Set end)

                // *** End programmer edit section *** (Person.Creator Set end)
            }
        }
        
        /// <summary>
        /// Время последнего редактирования объекта.
        /// </summary>
        // *** Start programmer edit section *** (Person.EditTime CustomAttributes)

        // *** End programmer edit section *** (Person.EditTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> EditTime
        {
            get
            {
                // *** Start programmer edit section *** (Person.EditTime Get start)

                // *** End programmer edit section *** (Person.EditTime Get start)
                System.Nullable<System.DateTime> result = this.fEditTime;
                // *** Start programmer edit section *** (Person.EditTime Get end)

                // *** End programmer edit section *** (Person.EditTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Person.EditTime Set start)

                // *** End programmer edit section *** (Person.EditTime Set start)
                this.fEditTime = value;
                // *** Start programmer edit section *** (Person.EditTime Set end)

                // *** End programmer edit section *** (Person.EditTime Set end)
            }
        }
        
        /// <summary>
        /// Последний редактор объекта.
        /// </summary>
        // *** Start programmer edit section *** (Person.Editor CustomAttributes)

        // *** End programmer edit section *** (Person.Editor CustomAttributes)
        [StrLen(255)]
        public virtual string Editor
        {
            get
            {
                // *** Start programmer edit section *** (Person.Editor Get start)

                // *** End programmer edit section *** (Person.Editor Get start)
                string result = this.fEditor;
                // *** Start programmer edit section *** (Person.Editor Get end)

                // *** End programmer edit section *** (Person.Editor Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Person.Editor Set start)

                // *** End programmer edit section *** (Person.Editor Set start)
                this.fEditor = value;
                // *** Start programmer edit section *** (Person.Editor Set end)

                // *** End programmer edit section *** (Person.Editor Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "AuditView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View AuditView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("AuditView", typeof(NewPlatform.SampleV5toV6.Person));
                }
            }
            
            /// <summary>
            /// "PersonE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View PersonE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("PersonE", typeof(NewPlatform.SampleV5toV6.Person));
                }
            }
            
            /// <summary>
            /// "PersonL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View PersonL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("PersonL", typeof(NewPlatform.SampleV5toV6.Person));
                }
            }
        }
        
        /// <summary>
        /// Audit class settings.
        /// </summary>
        public class AuditSettings
        {
            
            /// <summary>
            /// Включён ли аудит для класса.
            /// </summary>
            public static bool AuditEnabled = true;
            
            /// <summary>
            /// Использовать имя представления для аудита по умолчанию.
            /// </summary>
            public static bool UseDefaultView = false;
            
            /// <summary>
            /// Включён ли аудит операции чтения.
            /// </summary>
            public static bool SelectAudit = false;
            
            /// <summary>
            /// Имя представления для аудирования операции чтения.
            /// </summary>
            public static string SelectAuditViewName = "AuditView";
            
            /// <summary>
            /// Включён ли аудит операции создания.
            /// </summary>
            public static bool InsertAudit = true;
            
            /// <summary>
            /// Имя представления для аудирования операции создания.
            /// </summary>
            public static string InsertAuditViewName = "AuditView";
            
            /// <summary>
            /// Включён ли аудит операции изменения.
            /// </summary>
            public static bool UpdateAudit = false;
            
            /// <summary>
            /// Имя представления для аудирования операции изменения.
            /// </summary>
            public static string UpdateAuditViewName = "AuditView";
            
            /// <summary>
            /// Включён ли аудит операции удаления.
            /// </summary>
            public static bool DeleteAudit = true;
            
            /// <summary>
            /// Имя представления для аудирования операции удаления.
            /// </summary>
            public static string DeleteAuditViewName = "AuditView";
            
            /// <summary>
            /// Путь к форме просмотра результатов аудита.
            /// </summary>
            public static string FormUrl = "";
            
            /// <summary>
            /// Режим записи данных аудита (синхронный или асинхронный).
            /// </summary>
            public static ICSSoft.STORMNET.Business.Audit.Objects.tWriteMode WriteMode = ICSSoft.STORMNET.Business.Audit.Objects.tWriteMode.Synchronous;
            
            /// <summary>
            /// Максимальная длина сохраняемого значения поля (если 0, то строка обрезаться не будет).
            /// </summary>
            public static int PrunningLength = 0;
            
            /// <summary>
            /// Показывать ли пользователям в изменениях первичные ключи.
            /// </summary>
            public static bool ShowPrimaryKey = false;
            
            /// <summary>
            /// Сохранять ли старое значение.
            /// </summary>
            public static bool KeepOldValue = true;
            
            /// <summary>
            /// Сжимать ли сохраняемые значения.
            /// </summary>
            public static bool Compress = false;
            
            /// <summary>
            /// Сохранять ли все значения атрибутов, а не только изменяемые.
            /// </summary>
            public static bool KeepAllValues = false;
        }
    }
}
