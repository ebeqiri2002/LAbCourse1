﻿namespace Crud_Operation.CommonLayer.Model
{
    public class ReadRecordRequest
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int Age { get; set; }
    }
    public class UpdateRecordRequest
    {
        public int Id { get; set; }
        public string UserName { get; set; }    
        public int Age { get; set; }
    }

    public class UpdateRecordResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
