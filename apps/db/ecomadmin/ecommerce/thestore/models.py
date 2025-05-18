import uuid
from django.db import models

# Create your models here.
class StoreTypes(models.Model):
    name = models.CharField(max_length=50)

    class Meta:
        db_table = "store_types"

class Stores(models.Model):
    external_id = models.UUIDField(default=uuid.uuid4, editable=False, unique=True, auto_created=True)
    name = models.CharField(max_length=100)
    description = models.CharField(max_length=100)
    store_types = models.ForeignKey(StoreTypes, on_delete=models.CASCADE, related_name="stores_store_types")
    is_deleted = models.BooleanField
    created_at = models.DateTimeField(auto_now_add=True)
    created_by = models.CharField(max_length=50)
    updated_at = models.DateTimeField(null=True)
    updated_by = models.DateField(null=True)

    class Meta:
        db_table = "stores"

class ProductTypes(models.Model):
    name = models.CharField(max_length=50)

    class Meta:
        db_table = "product_types"

class Products(models.Model):
    external_id = models.UUIDField(default=uuid.uuid4, editable=False, unique=True, auto_created=True)
    store_id = models.ForeignKey(Stores, on_delete=models.CASCADE, related_name="products_stores")
    image = models.CharField(max_length=100)
    name = models.CharField(max_length=100)
    description = models.CharField(max_length=100)
    product_type = models.ForeignKey(ProductTypes, on_delete=models.CASCADE, related_name="products_product_types")
    price = models.DecimalField(max_digits=10, decimal_places=2)
    is_available = models.BooleanField
    is_deleted = models.BooleanField
    created_at = models.DateTimeField(auto_now_add=True)
    created_by = models.CharField(max_length=50)
    updated_at = models.DateTimeField(null=True)
    updated_by = models.DateField(null=True)

    class Meta:
        db_table = "products"
    


    