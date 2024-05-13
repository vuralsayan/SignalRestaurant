using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.MessageDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpGet]
        public IActionResult MessageList()
        {
            var values = _messageService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateMessage(CreateMessageDto createMessageDto)
        {
            Message message = new Message()
            {
                NameSurname = createMessageDto.NameSurname,
                Mail = createMessageDto.Mail,
                Phone = createMessageDto.Phone,
                Subject = createMessageDto.Subject,
                MessageContent = createMessageDto.MessageContent,
                MessageSendDate = DateTime.Now,
                Status = false
            };

            _messageService.TAdd(message);
            return Ok("Mesaj başarılı bir şekilde gönderildi");
        }
        [HttpDelete]
        public IActionResult DeleteMessage(int id)
        {
            var value = _messageService.TGetByID(id);
            _messageService.TDelete(value);
            return Ok("Mesaj başarılı bir şekilde silindi");
        }

        [HttpPut]
        public IActionResult UpdateMessage(UpdateMessageDto updateMessageDto)
        {
            Message message = new Message()
            {
                MessageID = updateMessageDto.MessageID,
                Mail = updateMessageDto.Mail,
                MessageContent = updateMessageDto.MessageContent,
                MessageSendDate = updateMessageDto.MessageSendDate,
                NameSurname = updateMessageDto.NameSurname,
                Phone = updateMessageDto.Phone,
                Status = updateMessageDto.Status,
            };
            _messageService.TUpdate(message);
            return Ok("Mesaj başarılı bir şekilde güncellendi");
        }

        [HttpGet("GetMessage")]
        public IActionResult GetMessage(int id)
        {
            var value = _messageService.TGetByID(id);
            return Ok(value);
        }

        [HttpGet("ChangeMessageStatusTrue")]
        public IActionResult ChangeMessageStatusTrue(int id)
        {
            _messageService.TChangeMessageStatusTrue(id);
            return Ok("Mesaj başarılı bir şekilde okundu");
        }

        [HttpGet("ChangeMessageStatusFalse")]
        public IActionResult ChangeMessageStatusFalse(int id)
        {
            _messageService.TChangeMessageStatusFalse(id);
            return Ok("Mesaj başarılı bir şekilde okunmadı");
        }

        [HttpGet("MessageCountByStatusFalse")]
        public IActionResult MessageCountByStatusFalse()
        {
            var value = _messageService.TMessageCountByStatusFalse();
            return Ok(value);
        }
    }
}
