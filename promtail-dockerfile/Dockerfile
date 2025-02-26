# Use the official Promtail image from Grafana
FROM grafana/promtail:2.9.4

# Expose Promtail's default port
EXPOSE 9080

# Copy custom Promtail configuration (if needed)
# COPY ./config/promtail-config.yaml /etc/promtail/config.yaml

# Define volumes
VOLUME ./config/promtail-config.yml:/etc/promtail/config.yml \
        /var/log:/var/log

# Command to run Promtail
CMD ["/usr/bin/promtail", "-config.file=/etc/promtail/config.yaml"]
