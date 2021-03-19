using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityHandson
{
    public class LeaveRequest
    {
        public string Employee { get; set; }
        public int LeaveDays { get; set; }
    }
   
    public interface ILeaveRequestHandler
    {
        void HandleRequest(LeaveRequest request);
        ILeaveRequestHandler nextHandler { get; set; }
    }
    
    public class Supervisor : ILeaveRequestHandler
    {
        public ILeaveRequestHandler nextHandler { get; set; }
        public void HandleRequest(LeaveRequest request)
        {
            if (request.LeaveDays <= 10)
            {
                Console.WriteLine("Leave request:- Employee: {0}, Leave days: {1} - approved by supervisor", request.Employee, request.LeaveDays);
            }
            else
            {
                nextHandler.HandleRequest(request);
            }
        }
    }


    public class ProjectManager : ILeaveRequestHandler
    {
        public ILeaveRequestHandler nextHandler { get; set; }
        public void HandleRequest(LeaveRequest request)
        {
            if (request.LeaveDays <= 30)
            {
                Console.WriteLine("Leave request:- Employee: {0}, Leave days: {1} - approved by project manager", request.Employee, request.LeaveDays);
            }
            else
            {
                nextHandler.HandleRequest(request);
            }
        }
    }



    public class HR : ILeaveRequestHandler
    {
        public ILeaveRequestHandler nextHandler { get; set; }
        public void HandleRequest(LeaveRequest request)
        {
            if (request.LeaveDays > 30)
            {
                Console.WriteLine("Leave request:- Employee: {0}, Leave days: {1} - approved by HR", request.Employee, request.LeaveDays);
            }
            else
            {
                nextHandler.HandleRequest(request);
            }
        }
    }
}
