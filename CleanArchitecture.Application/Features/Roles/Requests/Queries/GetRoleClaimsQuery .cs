﻿using CleanArchitecture.Application.Bases;
using MediatR;

namespace CleanArchitecture.Application.Features.Roles.Requests.Queries
{
    public class GetRoleClaimsQuery : IRequest<BaseResponse<IEnumerable<string>>>
    {
        public string RoleName { get; set; }
    }
}
