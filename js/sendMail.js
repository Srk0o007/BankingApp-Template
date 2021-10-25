var basepostUrl="http://119.82.68.85:8086/sendmail/API/sendmail/";

function sendmail(to,subject,body,option)
{
 
var fullUrl= basepostUrl + option;
$.ajax({
  url: fullUrl,
  headers: { 
    'Accept': 'application/json',
    'Content-Type': 'application/json' 
  },
  type: "POST", /* or type:"GET" or type:"PUT" */
  dataType: "json",
  data: JSON.stringify({
    "To": to, "Subject": subject,"Body": body 
  }),
  success: function (result) {
      console.log(result);
  },
  error: function (error) {
      console.log(error);
  }
});
};

function validateEmail($email) {
  var emailReg = /^([\w-\.]+@([\w-]+\.)+[\w-]{2,4})?$/;
  return emailReg.test( $email );
};

