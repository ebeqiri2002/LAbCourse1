namespace Crud_Operation.CommonLayer.Model
{
    public class DeleteRecordRequest
    {
        public int Id { get; set; }
      /*  public bool IsSuccess { get; internal set; }
        public string Message { get; internal set; }*/

        public static implicit operator DeleteRecordRequest(DeleteRecordResponse v)
        {
            throw new NotImplementedException();
        }
    }

    public class DeleteRecordResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; } 
    }
}
