//Module pattern
(() => {

    //GLOBAL FUNTIONS
    const GlobalSuccessAlert = (title, text) => {
        // Llama a la función Swal.fire para mostrar la alerta
        Swal.fire({
            title: title,
            text: text,
            icon: 'success',
            confirmButtonText: 'Ok'
        });
    }

    const GlobalErrorAlert = (text) => {
        text = text != undefined ? text : 'It was not possible to process the request'
        Swal.fire({
            title: 'Error',
            text: text,
            icon: 'error',
            confirmButtonText: 'Ok'
        });
    }

    const LoadGlobalTable = (table, dataList, notClean) => {
        // Declarar tabla 
        let dataTable = table.DataTable();
        if (!notClean) {
            // Limpiar los datos existentes 
            dataTable.clear();
        }
        // Agregar los nuevos datos al DataTable 
        dataTable.rows.add(dataList).draw();
    }

    //GLOBAL VARIABLES
    const Controller = '/Candidates/';
    let idEditCandidate = 0
    let editRow = null

    $('#CandidatesTable').DataTable({
        "lengthMenu": [10, 20, 50, 100],
        "pageLength": 10,
        "order": false,
        "language": {
            "search": '<label><i class="fas fa-search"></i><input type="search" class="form-control form-control-sm datatable" placeholder="Buscar..."></label>',
            "paginate": {
                "first": "Primera",
                "last": "Última",
                "next": "Siguiente",
                "previous": "Anterior"
            },
            "lengthMenu": "Mostrar _MENU_ registros por página",
            "search": "Buscar:",
            "info": "Mostrando _START_ al _END_ de _TOTAL_ registros"
        },
        "data": [],
        "ordering": true,
        "info": true,
        "columns": [
            {"data": 'Name'},
            {"data": 'Surname'},
            {
                "data": 'Birthdate',
                "render": function (data, type, row) {
                    data = (!data) ? '' : moment(data).format('YYYY-MM-DD')
                    return data
                }
            },
            {"data": 'Email' },
            {
                "data": 'InsertDate',
                "render": function (data, type, row) {
                    data = (!data) ? '' : moment(data).format('YYYY-MM-DD')
                    return data
                }
            },
            {
                "data": 'ModifyDate',
                "render": function (data, type, row) {
                    data = (!data) ? '' : moment(data).format('YYYY-MM-DD')
                    return data
                }
            },
            {
                "data": null,
                "render": function (data, type, row) {
                    let domView = `<i class="viewCandidates fas fa-eye fa-lg profile-icons pointer" data-IdCandidate="${row.IdCandidate}"> </i>`;
                    let domEdit = `<i class="editCandidates fas fa-edit fa-lg profile-icons pointer" data-IdCandidate="${row.IdCandidate}"> </i> `
                    let domConsult = `<i class="deleteCandidates fas fa-trash fa-lg profile-icons pointer" data-IdCandidate="${row.IdCandidate}"></i>`;
                    let dom = '<div class="d-flex justify-content-around">' + domView + domEdit + domConsult + '</div>';
                    return dom
                }
            }
        ],
        "pagingType": "full_numbers", // Tipo de paginación
        "paging": true,
        "lengthChange": true,
        "searching": true,
        dom: '<"row"<"col-sm-12 col-md-12"l>>' +
            '<"row"<"col-md-6"B><"col-md-6"f>>' +
            '<"row"<"col-sm-12"tr>>' +
            '<"row"<"col-sm-12 col-md-5"i><"col-sm-12 col-md-7"p>>',
        "buttons": [ // Botones de exportación
            {
                extend: 'copy',
                text: 'Copiar',
                titleAttr: 'Copiar al portapapeles',
                className: 'btn btn-outline-primary btn-sm btnExport'
            },
            {
                extend: 'excelHtml5',
                text: 'Excel',
                titleAttr: 'Exportar a Excel',
                className: 'btn btn-outline-primary btn-sm btnExport',
                filename: `Candidates`
            },
            {
                extend: 'pdfHtml5',
                text: 'PDF',
                titleAttr: 'Exportar a PDF',
                className: 'btn btn-outline-primary btn-sm btnExport',
                filename: `Candidates`
            },
            {
                extend: 'print',
                text: 'Imprimir',
                titleAttr: 'Imprimir',
                className: 'btn btn-outline-primary btn-sm btnExport'
            },
            {
                extend: 'colvis',
                className: 'btn btn-outline-primary btn-sm btnExport',
                text: 'Visibilidad de columnas'
            }
        ]
    });

    $('#CandidatesExpTable').DataTable({
        "lengthMenu": [10, 20, 50, 100],
        "pageLength": 10,
        "order": false,
        "language": {
            "search": '<label><i class="fas fa-search"></i><input type="search" class="form-control form-control-sm datatable" placeholder="Buscar..."></label>',
            "paginate": {
                "first": "Primera",
                "last": "Última",
                "next": "Siguiente",
                "previous": "Anterior"
            },
            "lengthMenu": "Mostrar _MENU_ registros por página",
            "search": "Buscar:",
            "info": "Mostrando _START_ al _END_ de _TOTAL_ registros"
        },
        "data": [],
        "ordering": true,
        "info": true,
        "columns": [
            { "data": 'Company' },
            { "data": 'Job' },
            { "data": 'Description'},
            { "data": 'Salary' },
            {
                "data": 'BeginDate',
                "render": function (data, type, row) {
                    data = (!data) ? '' : moment(data).format('YYYY-MM-DD')
                    return data
                }
            },
            {
                "data": 'EndDate',
                "render": function (data, type, row) {
                    data = (!data) ? '' : moment(data).format('YYYY-MM-DD')
                    return data
                }
            },
            {
                "data": null,
                "render": function (data, type, row) {
                    let domConsult = `<i class="deleteExperiences fas fa-trash fa-lg profile-icons" data-IdCandidate="${row.IdCandidate}"></i>`;
                    let dom = '<div class="d-flex justify-content-around">' + domConsult + '</div>';
                    return dom
                }
            }
        ],
        "pagingType": "full_numbers", // Tipo de paginación
        "paging": true,
        "lengthChange": true,
        "searching": true,
        dom: '<"row"<"col-sm-12 col-md-12"l>>' +
            '<"row"<"col-md-6"B><"col-md-6"f>>' +
            '<"row"<"col-sm-12"tr>>' +
            '<"row"<"col-sm-12 col-md-5"i><"col-sm-12 col-md-7"p>>',
        "buttons": [ // Botones de exportación
            {
                extend: 'copy',
                text: 'Copiar',
                titleAttr: 'Copiar al portapapeles',
                className: 'btn btn-outline-primary btn-sm btnExport'
            },
            {
                extend: 'excelHtml5',
                text: 'Excel',
                titleAttr: 'Exportar a Excel',
                className: 'btn btn-outline-primary btn-sm btnExport',
                filename: `Candidates`
            },
            {
                extend: 'pdfHtml5',
                text: 'PDF',
                titleAttr: 'Exportar a PDF',
                className: 'btn btn-outline-primary btn-sm btnExport',
                filename: `Candidates`
            },
            {
                extend: 'print',
                text: 'Imprimir',
                titleAttr: 'Imprimir',
                className: 'btn btn-outline-primary btn-sm btnExport'
            },
            {
                extend: 'colvis',
                className: 'btn btn-outline-primary btn-sm btnExport',
                text: 'Visibilidad de columnas'
            }
        ]
    });

    $('#CandidatesViewExpTable').DataTable({
        "lengthMenu": [10, 20, 50, 100],
        "pageLength": 10,
        "order": false,
        "language": {
            "search": '<label><i class="fas fa-search"></i><input type="search" class="form-control form-control-sm datatable" placeholder="Buscar..."></label>',
            "paginate": {
                "first": "Primera",
                "last": "Última",
                "next": "Siguiente",
                "previous": "Anterior"
            },
            "lengthMenu": "Mostrar _MENU_ registros por página",
            "search": "Buscar:",
            "info": "Mostrando _START_ al _END_ de _TOTAL_ registros"
        },
        "data": [],
        "ordering": true,
        "info": true,
        "columns": [
            { "data": 'Company' },
            { "data": 'Job' },
            { "data": 'Description' },
            { "data": 'Salary' },
            {
                "data": 'BeginDate',
                "render": function (data, type, row) {
                    data = (!data) ? '' : moment(data).format('YYYY-MM-DD')
                    return data
                }
            },
            {
                "data": 'EndDate',
                "render": function (data, type, row) {
                    data = (!data) ? '' : moment(data).format('YYYY-MM-DD')
                    return data
                }
            },
            {
                "data": 'InsertDate',
                "render": function (data, type, row) {
                    data = (!data) ? '' : moment(data).format('YYYY-MM-DD')
                    return data
                }
            },
            {
                "data": 'ModifyDate',
                "render": function (data, type, row) {
                    data = (!data) ? '' : moment(data).format('YYYY-MM-DD')
                    return data
                }
            },
        ],
        "pagingType": "full_numbers", // Tipo de paginación
        "paging": true,
        "lengthChange": true,
        "searching": true,
        dom: '<"row"<"col-sm-12 col-md-12"l>>' +
            '<"row"<"col-md-6"B><"col-md-6"f>>' +
            '<"row"<"col-sm-12"tr>>' +
            '<"row"<"col-sm-12 col-md-5"i><"col-sm-12 col-md-7"p>>',
        "buttons": [ // Botones de exportación
            {
                extend: 'copy',
                text: 'Copiar',
                titleAttr: 'Copiar al portapapeles',
                className: 'btn btn-outline-primary btn-sm btnExport'
            },
            {
                extend: 'excelHtml5',
                text: 'Excel',
                titleAttr: 'Exportar a Excel',
                className: 'btn btn-outline-primary btn-sm btnExport',
                filename: `Candidates`
            },
            {
                extend: 'pdfHtml5',
                text: 'PDF',
                titleAttr: 'Exportar a PDF',
                className: 'btn btn-outline-primary btn-sm btnExport',
                filename: `Candidates`
            },
            {
                extend: 'print',
                text: 'Imprimir',
                titleAttr: 'Imprimir',
                className: 'btn btn-outline-primary btn-sm btnExport'
            },
            {
                extend: 'colvis',
                className: 'btn btn-outline-primary btn-sm btnExport',
                text: 'Visibilidad de columnas'
            }
        ]
    });

    $('#CandidatesEditExpTable').DataTable({
        "lengthMenu": [10, 20, 50, 100],
        "pageLength": 10,
        "order": false,
        "language": {
            "search": '<label><i class="fas fa-search"></i><input type="search" class="form-control form-control-sm datatable" placeholder="Buscar..."></label>',
            "paginate": {
                "first": "Primera",
                "last": "Última",
                "next": "Siguiente",
                "previous": "Anterior"
            },
            "lengthMenu": "Mostrar _MENU_ registros por página",
            "search": "Buscar:",
            "info": "Mostrando _START_ al _END_ de _TOTAL_ registros"
        },
        "data": [],
        "ordering": true,
        "info": true,
        "columns": [
            { "data": 'Company' },
            { "data": 'Job' },
            { "data": 'Description' },
            { "data": 'Salary' },
            {
                "data": 'BeginDate',
                "render": function (data, type, row) {
                    data = (!data) ? '' : moment(data).format('YYYY-MM-DD')
                    return data
                }
            },
            {
                "data": 'EndDate',
                "render": function (data, type, row) {
                    data = (!data) ? '' : moment(data).format('YYYY-MM-DD')
                    return data
                }
            },
            {
                "data": null,
                "render": function (data, type, row) {
                    let domEdit = `<i class="editExperiences fas fa-edit fa-lg profile-icons pointer" data-IdCandidate="${row.IdCandidateExperience}"> </i> `
                    let dom = '<div class="d-flex justify-content-around">' + domEdit + '</div>';
                    return dom
                }
            }
        ],
        "pagingType": "full_numbers", // Tipo de paginación
        "paging": true,
        "lengthChange": true,
        "searching": true,
        dom: '<"row"<"col-sm-12 col-md-12"l>>' +
            '<"row"<"col-md-6"B><"col-md-6"f>>' +
            '<"row"<"col-sm-12"tr>>' +
            '<"row"<"col-sm-12 col-md-5"i><"col-sm-12 col-md-7"p>>',
        "buttons": [ // Botones de exportación
            {
                extend: 'copy',
                text: 'Copiar',
                titleAttr: 'Copiar al portapapeles',
                className: 'btn btn-outline-primary btn-sm btnExport'
            },
            {
                extend: 'excelHtml5',
                text: 'Excel',
                titleAttr: 'Exportar a Excel',
                className: 'btn btn-outline-primary btn-sm btnExport',
                filename: `Candidates`
            },
            {
                extend: 'pdfHtml5',
                text: 'PDF',
                titleAttr: 'Exportar a PDF',
                className: 'btn btn-outline-primary btn-sm btnExport',
                filename: `Candidates`
            },
            {
                extend: 'print',
                text: 'Imprimir',
                titleAttr: 'Imprimir',
                className: 'btn btn-outline-primary btn-sm btnExport'
            },
            {
                extend: 'colvis',
                className: 'btn btn-outline-primary btn-sm btnExport',
                text: 'Visibilidad de columnas'
            }
        ]
    });

    //GET CANDIDATES LIST
    const GetCandidatesList = () => {
        $.ajax({
            type: 'GET',
            url: `${Controller}GetCandidates`,
            success: (response) => {
                let apiResponse = $.parseJSON(response);
                LoadGlobalTable($('#CandidatesTable'), apiResponse)
            },
            error: (error) => {
                GlobalErrorAlert();
            }
        })
    }

    GetCandidatesList();

    //CREATE CANDIDATES
    $('#createCandidates').on('click', function () {
        $('#ModalCreateCandidates').modal('show');
    });

    //CREATE EXPERIENCE
    $('#createExperience').on('click', function () {
        $('#ModalAddExperience').modal('show');
    });

    //SAVE EXPERIENCE
    $('#addExperience').on('click', function () {
        let Company = $('#addCompany').val();
        let Job = $('#addJob').val();
        let Description = $('#addDescription').val()
        let Salary = $('#addSalary').val();
        let BeginDate = $('#addBeginDate').val();
        let EndDate = $('#addEndDate').val();

        const data = [{
            "Company": Company,
            "Job": Job,
            "Description": Description,
            "Salary": Salary,
            "BeginDate": BeginDate,
            "EndDate": EndDate
        }]

        //insert table
        let dataTable = $('#CandidatesExpTable').DataTable();
        dataTable.rows.add(data);
        dataTable.draw();

        $('.ModalAddExperience-Clear').val('');

        $('#ModalAddExperience').modal('hide')

        GlobalSuccessAlert('SAVE', 'Success');
    });

    //DELETE EXPERIENCE
    $(document).on('click', '.deleteExperiences', function () {
        let dataTable = $('#CandidatesExpTable').DataTable();
        var fila = $(this).closest('tr');
        dataTable.row(fila).remove();
        dataTable.draw(false);
    });

    //SAVE CANDIDATE
    $('#createCandidate').on('click', function () {
        let dataTable = $('#CandidatesExpTable').DataTable();
        let dataSave = {
            "Name": $('#CreateName').val(),
            "Surname": $('#CreateSurName').val(),
            "Birthdate": $('#CreateBirthdate').val(),
            "Email": $('#CreateEmail').val(),
            "Candidateexperiences":dataTable.rows().data().toArray()
        }

        $.ajax({
            type: 'POST',
            url: `${Controller}SaveCandidates`,
            data: {
                "candidates": dataSave
            },
            success: (response) => {
                let responseApi = $.parseJSON(response)
                if (responseApi) {
                    $('#create-inputs').val('');
                    let dataTable = $('#CandidatesExpTable').DataTable();
                    dataTable.clear();
                    dataTable.draw();
                    $('#ModalCreateCandidates').modal('hide');
                    GlobalSuccessAlert('SAVE', 'Success');
                    GetCandidatesList();
                } else {
                    GlobalErrorAlert();
                }
            },
            error: (error) => {
                GlobalErrorAlert()
            }
        })
    });

    //VIEW CANDIDATE
    $(document).on('click', '.viewCandidates', function () {
        let table = $('#CandidatesTable').DataTable()
        const row = table.row($(this).closest('tr')).data();
        const IdCandidate = $(this).attr('data-idcandidate');

        $('#ModalViewCandidates').modal('show');
        $.ajax({
            type: 'GET',
            url: `${Controller}GetCandidatesDetail`,
            data: {
                "IdCandidate": IdCandidate
            },
            success: (response) => {
                let responseApi = $.parseJSON(response)
                    $('#ViewName').val(row.Name);
                    $('#ViewSurName').val(row.Surname);
                    $('#ViewBirthdate').val(moment(row.Birthdate).format('YYYY-MM-DD'));
                    $('#ViewEmail').val(row.Email);
                    LoadGlobalTable($('#CandidatesViewExpTable'), responseApi);
            },
            error: (error) => {
                GlobalErrorAlert()
            }
        })
    });

    //VIEW EDIT CANDIDATE
    $(document).on('click', '.editCandidates', function () {
        let table = $('#CandidatesTable').DataTable()
        const row = table.row($(this).closest('tr')).data();
        const IdCandidate = $(this).attr('data-idcandidate');
        idEditCandidate = IdCandidate

        $('#ModalEditCandidates').modal('show');
        $.ajax({
            type: 'GET',
            url: `${Controller}GetCandidatesDetail`,
            data: {
                "IdCandidate": IdCandidate
            },
            success: (response) => {
                let responseApi = $.parseJSON(response)
                $('#EditName').val(row.Name);
                $('#EditSurName').val(row.Surname);
                $('#EditBirthdate').val(moment(row.Birthdate).format('YYYY-MM-DD'));
                $('#EditEmail').val(row.Email);
                LoadGlobalTable($('#CandidatesEditExpTable'), responseApi);
            },
            error: (error) => {
                GlobalErrorAlert()
            }
        })
    });

    //VIEW EDIT EXPERIENCES
    $(document).on('click', '.editExperiences', function () {
        let table = $('#CandidatesEditExpTable').DataTable()
        editRow = table.row($(this).closest('tr'))
        const row = table.row($(this).closest('tr')).data();
        $('#editCompany').val(row.Company);
        $('#editJob').val(row.Job);
        $('#editDescription').val(row.Description);
        $('#editSalary').val(row.Salary);
        $('#editBeginDate').val(moment(row.Birthdate).format('YYYY-MM-DD'));
        $('#editEndDate').val(moment(row.EndDate).format('YYYY-MM-DD'));
        $('#ModalEditExperience').modal('show');
    });

    //SAVE EDIT EXPERIENCE
    $('#EditExperience').on('click', function () {
        const table = $('#CandidatesEditExpTable').DataTable();
        const row = table.row(editRow);

        const existingData = row.data();

        // Obtén los valores del formulario
        const newData = {
            "Company": $('#editCompany').val(),
            "Job": $('#editJob').val(),
            "Description": $('#editDescription').val(),
            "Salary": $('#editSalary').val(),
            "BeginDate": $('#editBeginDate').val(),
            "EndDate": $('#editEndDate').val(),
        }

        const mergedData = {
            ...existingData,
            ...newData
        };

        row.data(mergedData).draw();

        $('#ModalEditExperience').modal('hide');
    });

    //SAVE EDIT CANDIDATE
    $('#editCandidate').on('click', function () {
        let dataTable = $('#CandidatesEditExpTable').DataTable();
        let dataSave = {
            "Name": $('#EditName').val(),
            "Surname": $('#EditSurName').val(),
            "Birthdate": $('#EditBirthdate').val(),
            "Email": $('#EditEmail').val(),
            "Candidateexperiences": dataTable.rows().data().toArray()
        }

        $.ajax({
            type: 'PUT',
            url: `${Controller}EditCandidates`,
            data: {
                "candidates": dataSave,
                "IdCandidate":dataSave.Candidateexperiences[0].IdCandidate
            },
            success: (response) => {
                let responseApi = $.parseJSON(response)
                if (responseApi) {
                    $('#ModalEditCandidates').modal('hide');
                    GlobalSuccessAlert('SAVE', 'Success');
                    GetCandidatesList();
                } else {
                    GlobalErrorAlert();
                }
            },
            error: (error) => {
                GlobalErrorAlert()
            }
        })
    })

    //DELETE CANDIDATE
    $(document).on('click', '.deleteCandidates', function () {
        const IdCandidate = $(this).attr('data-idcandidate');
        $.ajax({
            type: 'DELETE',
            url: `${Controller}DeleteCandidate`,
            data: {
                "IdCandidate": IdCandidate
            },
            success: (response) => {
                GlobalSuccessAlert('SAVE', 'Success');
                GetCandidatesList();
            },
            error: (error) => {
                GlobalErrorAlert()
            }
        })
    });

})()