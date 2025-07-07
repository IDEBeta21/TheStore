from django.contrib import admin
from .models import StoreTypes, ProductTypes

# Register your models here.
admin.site.register(StoreTypes)
admin.site.register(ProductTypes)