from django.db import models
from django.utils import timezone

class AuditHelper(models.Model):
    created_at = models.DateTimeField(auto_now_add=True)
    created_by = models.CharField(max_length=50, default='')
    updated_at = models.DateTimeField(null=True)
    updated_by = models.CharField(max_length=50, null=True, blank=True)

    class Meta:
        abstract = True