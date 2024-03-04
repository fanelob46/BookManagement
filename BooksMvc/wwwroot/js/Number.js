new DataTable('#example', {
    columnDefs: [
        {
            target: 4,
            render: DataTable.render.date()
        },
        {
            target: 5,
            render: DataTable.render.number(null, null, 0, '$')
        }
    ]
});