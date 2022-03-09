//subscribed
$(function () {
    /*$('#subscribe-alert').hide();*/
    $('#btn-subscribe').click(function (e) {
        e.preventDefault();
        console.log('clicked');

        var email = $('#newsletter-subscribe').val();
        console.log(email + ' from email');

        if (email != null) {
            $.ajax({
                type: "POST",
                url: "/Newsletter/GetSubscribed",
                data: { name: "Newsletter", email: email }, 
                success: function (data) {
                    if (data.length !== 0) {
                        console.log(data);
                       /* $('#subscribe-alert').show();*/
                        var alertElement = $('#subscribe-alert');
                        
                        function alert(message, type) {
                            var wrapper = document.createElement('div')
                            wrapper.innerHTML = '<div class="alert alert-' + type + ' alert-dismissible" role="alert">' + message + '<button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button></div>'

                            alertElement.append(wrapper)
                        }
         
                                alert('You are subscribed!', 'success')

                        }
                                    
                },
                error: function (data) {
                    console.log(data);
                }
            });
        }
    });

    
});