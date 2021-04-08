﻿
$(function () {

    $.ajax({
        url: "/HomePage/get_categorysname",
        type: "GET",
        success: function (data_category) {
            
                        var category_li = `<ul><li class="active"  id="FirstCate" data-filter=".categoryid_${data_category[0].cProductCategoryId}">${data_category[0].cCategoryName}</li>`;
                                for (let i = 1; i < data_category.length; i++) {
                                    category_li += `<li data-filter=".categoryid_${data_category[i].cProductCategoryId}">${data_category[i].cCategoryName}</li>`
                                 }
                                 category_li += `</li>`

            $("#push_procategory").append(category_li);
            pullme = data_category;console.log(pullme);
            for (let i = 0; i < data_category.length; i++) {
                var products = ""; 
                for (let y = 0; y < data_category[i].tProducts.length; y++) {
                   
                    products += `<div class="col-lg-3 col-md-4 col-sm-6 mix categoryid_${data_category[i].tProducts[y].cCategoryId}">
                                            <div class="featured__item">
                                                <div class="featured__item__pic set-bg" style="background-image: url(${data_category[i].tProducts[y].cPicture.replace("~", "")})">
                                                    <ul class="featured__item__pic__hover">
                                                        <li><a href="#"><i class="fa fa-heart"></i></a></li>
                                                        <li><a href="#"><i class="fa fa-retweet"></i></a></li>
                                                        <li><a href="javascript: void(0)" onclick="addCart(pullme[${i}].tProducts[${y}])"><i class="fa fa-shopping-cart"></i></a></li>
                                                    </ul>
                                                </div>
                                                <div class="featured__item__text">
                                                    <h6><a href="/ProductDetail/ProductData?id=${data_category[i].tProducts[y].cProductId}">${data_category[i].tProducts[y].cProductName}</a></h6>
                                                    <h5>$${data_category[i].tProducts[y].cPrice}</h5>
                                                </div>
                                            </div>
                                        </div>`
                }
                $("#many_products").append(products);
            }

            $('.featured__controls li').on('click', function () {

                $('.featured__controls li').removeClass('active');
                $(this).addClass('active');
            });
            if ($('.featured__filter').length > 0) {
                var containerEl = document.querySelector('.featured__filter');
                var mixer = mixitup(containerEl);
            }
            $("#FirstCate").click();

        }
    })
})
