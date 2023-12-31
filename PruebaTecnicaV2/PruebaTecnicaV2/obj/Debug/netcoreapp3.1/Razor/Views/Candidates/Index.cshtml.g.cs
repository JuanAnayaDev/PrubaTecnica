#pragma checksum "C:\Users\Spownchip\source\repos\PruebaTecnicaV2\PruebaTecnicaV2\Views\Candidates\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7d0072fef280114cbee7a8f27815eb11a303836"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Candidates_Index), @"mvc.1.0.view", @"/Views/Candidates/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Spownchip\source\repos\PruebaTecnicaV2\PruebaTecnicaV2\Views\_ViewImports.cshtml"
using PruebaTecnicaV2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Spownchip\source\repos\PruebaTecnicaV2\PruebaTecnicaV2\Views\_ViewImports.cshtml"
using PruebaTecnicaV2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7d0072fef280114cbee7a8f27815eb11a303836", @"/Views/Candidates/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d0c814c32e9c56fbbfbda45ab04acd2fd0cc40e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Candidates_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<button type=""button"" id=""createCandidates"" class=""btn btn-success"">Create Candidate</button>
<div class=""mt-2 table-responsive"">
    <div class=""table-container"">
        <table id=""CandidatesTable"" class=""table table-striped table-bordered modal-create-profiles resposive-table w-100"">
            <thead>
                <tr class=""text-white bg-primary text-center"">
                    <!-- <th>ProfileName</th> -->
                    <th>Name</th>
                    <th>Surname</th>
                    <th>Birthdate</th>
                    <th>Email</th>
                    <th>InsertDate</th>
                    <th>ModifyDate</th>
                    <th>Acciones</th>
                </tr>
            </thead>
            <tbody>
                <!-- agregar más filas aquí -->
            </tbody>
        </table>
    </div>
</div>

<!-------------------MODAL CREATE CANDIDATES------------------>

<div id=""ModalCreateCandidates"" class=""modal fade"" tabindex=""-1"" role=""dialog"" ari");
            WriteLiteral(@"a-labelledby=""CreateCandidatesLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-xl"">
        <div class=""modal-content"">
            <div class=""modal-header modal-header bg-primary text-white modal-header-custom"">
                <h5 class=""modal-title mr-5"">CREATE CANDIDATES</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body mt-3 mb-3"">
                <div class=""row"">
                    <div class=""col"">
                        <label>Name</label>
                        <input type=""text"" class=""form-control create-inputs"" id=""CreateName"" />
                    </div>
                    <div class=""col"">
                        <label>Surname</label>
                        <input type=""text"" class=""form-control create-inputs"" id=""CreateSurName"" />
                    </div>
                   ");
            WriteLiteral(@" <div class=""col"">
                        <label>Birthdate</label>
                        <input type=""date"" class=""form-control create-inputs"" id=""CreateBirthdate"" />
                    </div>
                    <div class=""col"">
                        <label>Email</label>
                        <input type=""text"" class=""form-control create-inputs"" id=""CreateEmail"" />
                    </div>
                </div>
                <button type=""button"" id=""createExperience"" class=""btn btn-primary mt-3"">Add Experience</button>
                <div class=""table-container mt-3"">
                    <table id=""CandidatesExpTable"" class=""table table-striped table-bordered modal-create-profiles resposive-table w-100 mt-3"">
                        <thead>
                            <tr class=""text-white bg-primary text-center"">
                                <!-- <th>ProfileName</th> -->
                                <th>Company</th>
                                <th>Job</th>
        ");
            WriteLiteral(@"                        <th>Description</th>
                                <th>Salary</th>
                                <th>BeginDate</th>
                                <th>EndDate</th>
                                <th>Acciones</th>
                            </tr>
                        </thead>
                        <tbody>
                            <!-- agregar más filas aquí -->
                        </tbody>
                    </table>
                </div>
                <button type=""button"" id=""createCandidate"" class=""btn btn-success mt-3"">Create Candidate</button>
            </div>
        </div>
    </div>
</div>

<!-------------------MODAL CREATE CANDIDATES------------------>

<div id=""ModalAddExperience"" class=""modal fade"" tabindex=""-1"" role=""dialog"" aria-labelledby=""CreateCandidatesLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-xl"">
        <div class=""modal-content"">
            <div class=""modal-header modal-header bg-primary text-whit");
            WriteLiteral(@"e modal-header-custom"">
                <h5 class=""modal-title mr-5"">CREATE EXPERIENCE</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body mt-3 mb-3"">
                <div class=""row"">
                    <div class=""col"">
                        <label>Company</label>
                        <input type=""text"" class=""form-control ModalAddExperience-Clear"" id=""addCompany"" />
                    </div>
                    <div class=""col"">
                        <label>Job</label>
                        <input type=""text"" class=""form-control ModalAddExperience-Clear"" id=""addJob"" />
                    </div>
                    <div class=""col"">
                        <label>Description</label>
                        <input type=""text"" class=""form-control ModalAddExperience-Clear"" id=""addDescription"" />
       ");
            WriteLiteral(@"             </div>
                </div>
                <div class=""row"">
                    <div class=""col"">
                        <label>Salay</label>
                        <input type=""text"" class=""form-control ModalAddExperience-Clear"" id=""addSalary"" />
                    </div>
                    <div class=""col"">
                        <label>BeginDate</label>
                        <input type=""date"" class=""form-control ModalAddExperience-Clear"" id=""addBeginDate"" />
                    </div>
                    <div class=""col"">
                        <label>endDate</label>
                        <input type=""date"" class=""form-control ModalAddExperience-Clear"" id=""addEndDate"" />
                    </div>
                </div>
                <button type=""button"" id=""addExperience"" class=""btn btn-success mt-3"">Create Experience</button>
            </div>
        </div>
    </div>
</div>

<!-------------------MODAL VIEW CANDIDATES------------------>
<div id=""Mod");
            WriteLiteral(@"alViewCandidates"" class=""modal fade"" tabindex=""-1"" role=""dialog"" aria-labelledby=""ViewCandidatesLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-xl"">
        <div class=""modal-content"">
            <div class=""modal-header modal-header bg-primary text-white modal-header-custom"">
                <h5 class=""modal-title mr-5"">VIEW CANDIDATES</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body mt-3 mb-3"">
                <div class=""row"">
                    <div class=""col"">
                        <label>Name</label>
                        <input type=""text"" class=""form-control"" id=""ViewName"" disabled/>
                    </div>
                    <div class=""col"">
                        <label>Surname</label>
                        <input type=""text"" class=""form-control"" id=""ViewSurName"" disabled />");
            WriteLiteral(@"
                    </div>
                    <div class=""col"">
                        <label>Birthdate</label>
                        <input type=""date"" class=""form-control"" id=""ViewBirthdate"" disabled />
                    </div>
                    <div class=""col"">
                        <label>Email</label>
                        <input type=""text"" class=""form-control"" id=""ViewEmail"" disabled />
                    </div>
                </div>
                <div class=""table-container mt-3"">
                    <table id=""CandidatesViewExpTable"" class=""table table-striped table-bordered modal-create-profiles resposive-table w-100 mt-3"">
                        <thead>
                            <tr class=""text-white bg-primary text-center"">
                                <!-- <th>ProfileName</th> -->
                                <th>Company</th>
                                <th>Job</th>
                                <th>Description</th>
                             ");
            WriteLiteral(@"   <th>Salary</th>
                                <th>BeginDate</th>
                                <th>EndDate</th>
                                <th>InsertDate</th>
                                <th>ModifyDate</th>
                            </tr>
                        </thead>
                        <tbody>
                            <!-- agregar más filas aquí -->
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>

<!-------------------MODAL EDIT CANDIDATES------------------>
<div id=""ModalEditCandidates"" class=""modal fade"" tabindex=""-1"" role=""dialog"" aria-labelledby=""EditCandidatesLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-xl"">
        <div class=""modal-content"">
            <div class=""modal-header modal-header bg-primary text-white modal-header-custom"">
                <h5 class=""modal-title mr-5"">EDIT CANDIDATES</h5>
                <button type=""button"" class=""clo");
            WriteLiteral(@"se"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body mt-3 mb-3"">
                <div class=""row"">
                    <div class=""col"">
                        <label>Name</label>
                        <input type=""text"" class=""form-control"" id=""EditName""  />
                    </div>
                    <div class=""col"">
                        <label>Surname</label>
                        <input type=""text"" class=""form-control"" id=""EditSurName"" />
                    </div>
                    <div class=""col"">
                        <label>Birthdate</label>
                        <input type=""date"" class=""form-control"" id=""EditBirthdate"" />
                    </div>
                    <div class=""col"">
                        <label>Email</label>
                        <input type=""text"" class=""form-control"" id=""EditEmail"" />
                    </div>");
            WriteLiteral(@"
                </div>
                <div class=""table-container mt-3"">
                    <table id=""CandidatesEditExpTable"" class=""table table-striped table-bordered modal-create-profiles resposive-table w-100 mt-3"">
                        <thead>
                            <tr class=""text-white bg-primary text-center"">
                                <th>Company</th>
                                <th>Job</th>
                                <th>Description</th>
                                <th>Salary</th>
                                <th>BeginDate</th>
                                <th>EndDate</th>
                                <th>Acciones</th>
                            </tr>
                        </thead>
                        <tbody>
                            <!-- agregar más filas aquí -->
                        </tbody>
                    </table>
                </div>
                <button type=""button"" id=""editCandidate"" class=""btn btn-success mt-3""");
            WriteLiteral(@">Edit Candidate</button>
            </div>
        </div>
    </div>
</div>

<!-------------------MODAL EDIT EXPERIENCES------------------>

<div id=""ModalEditExperience"" class=""modal fade"" tabindex=""-1"" role=""dialog"" aria-labelledby=""CreateCandidatesLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-xl"">
        <div class=""modal-content"">
            <div class=""modal-header modal-header bg-primary text-white modal-header-custom"">
                <h5 class=""modal-title mr-5"">EDIT EXPERIENCE</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body mt-3 mb-3"">
                <div class=""row"">
                    <div class=""col"">
                        <label>Company</label>
                        <input type=""text"" class=""form-control"" id=""editCompany"" />
                    </div>
                 ");
            WriteLiteral(@"   <div class=""col"">
                        <label>Job</label>
                        <input type=""text"" class=""form-control"" id=""editJob"" />
                    </div>
                    <div class=""col"">
                        <label>Description</label>
                        <input type=""text"" class=""form-control"" id=""editDescription"" />
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col"">
                        <label>Salay</label>
                        <input type=""text"" class=""form-control"" id=""editSalary"" />
                    </div>
                    <div class=""col"">
                        <label>BeginDate</label>
                        <input type=""date"" class=""form-control"" id=""editBeginDate"" />
                    </div>
                    <div class=""col"">
                        <label>endDate</label>
                        <input type=""date"" class=""form-control"" id=""editEndDate"" />
         ");
            WriteLiteral("           </div>\r\n                </div>\r\n                <button type=\"button\" id=\"EditExperience\" class=\"btn btn-success mt-3\">Edit Experience</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
